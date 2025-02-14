CREATE DATABASE HoaPhat2024
GO
USE HoaPhat2024
GO

CREATE TABLE Account(
	accountName NVARCHAR(50),
	userName VARCHAR(20) PRIMARY KEY,
	passWord VARCHAR(20) NOT NULL,
	role TINYINT NOT NULL
)

INSERT INTO Account VALUES (N'INTECH GROUP', 'admin', 'intech@2024', 1)

CREATE TABLE Model(
	modelCode VARCHAR(20) PRIMARY KEY,
	modelName NVARCHAR(50),
	grossWeight REAL NOT NULL, -- khối lượng tính cả bao bì
	toLerance TINYINT NOT NULL -- dung sai
)

CREATE TABLE Operator(
	modelCode VARCHAR(20) NOT NULL,
	numOperator TINYINT NOT NULL, -- số công đoạn 
	operatorName NVARCHAR(100), -- tên công đoạn
	excutionTime TIME NOT NULL, -- thời gian thực hiện
	isIgnore BIT NOT NULL, -- bỏ qua công đoạn
	CONSTRAINT fk_modelCode_Operator FOREIGN KEY (modelCode) REFERENCES Model(modelCode) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE ModelData(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	modelCode VARCHAR(20) NOT NULL,
	date DATETIME NOT NULL,
	expectedOutput SMALLINT NOT NULL, -- sản lượng dự kiến
	actualOutput SMALLINT NOT NULL, -- sản lượng thực tế
	CONSTRAINT fk_modelCode_ModelData FOREIGN KEY (modelCode) REFERENCES Model(modelCode) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE OperationData(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	numOperator TINYINT NOT NULL,
	modelCode VARCHAR(20) NOT NULL,
	date DATETIME NOT NULL,
	startTime TIME NOT NULL, -- thời gian bắt đầu thao tác
	endTime TIME NOT NULL, -- thời gian kết thúc thao tác
	CONSTRAINT fk_modelCode_OperationData FOREIGN KEY (modelCode) REFERENCES Model(modelCode) ON DELETE CASCADE ON UPDATE CASCADE
)

CREATE TABLE DataReader(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	modelCode VARCHAR(20) NOT NULL,
	date DATETIME NOT NULL,
	barcode VARCHAR(50),
	grossWeight REAL NOT NULL,
	CONSTRAINT fk_modelCode_DataReader FOREIGN KEY (modelCode) REFERENCES Model(modelCode) ON DELETE CASCADE ON UPDATE CASCADE
)

ALTER TABLE DataReader
ADD user_name NVARCHAR(50);

ALTER TABLE DataReader
ADD operator_name NVARCHAR(MAX);



CREATE TABLE Error(
	bitError VARCHAR(20) PRIMARY KEY,
	errorName NVARCHAR(50),
	solution NVARCHAR(100)
)

CREATE TABLE ErrorData(
	id INT IDENTITY (1, 1) PRIMARY KEY,
	ngay DATETIME NOT NULL,
	bitError VARCHAR(20) NOT NULL,

	CONSTRAINT fk_bitError_ErrorData FOREIGN KEY (bitError) REFERENCES Error(bitError) ON DELETE CASCADE ON UPDATE CASCADE
)

-- >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
ALTER PROCEDURE SelectOperationData(
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
SELECT ROW_NUMBER() OVER(ORDER BY Q0.id) AS 'numOrder', Q0.*,
CASE WHEN Q0.completedTime > Q0.excutionSecond THEN N'Chưa đạt' ELSE N'Đạt' END AS 'isReach'
FROM (
	SELECT OPD.*, 
	DATEDIFF(second, OPD.startTime, OPD.endTime)  AS 'completedTime', 
	DATEDIFF(second, '00:00:00', OP.excutionTime)  AS 'excutionSecond' -- thời gian cho phép
	FROM OperationData OPD
	INNER JOIN Operator OP ON OPD.modelCode = OP.modelCode AND OPD.numOperator = OP.numOperator
	WHERE OPD.date BETWEEN @startDate AND @endDate
)Q0;
END

DROP PROCEDURE SelectOperationData
EXEC SelectOperationData '2024-04-19 00:00:00', '2024-04-19 23:59:59'

-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
ALTER PROCEDURE SelectModelData(
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', *,
	CASE WHEN MD.actualOutput >= MD.expectedOutput THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
	FROM ModelData AS MD WHERE date BETWEEN @startDate AND @endDate
END

EXEC SelectModelData '2024-04-19 00:00:00', '2024-04-19 23:59:59'

DROP PROCEDURE SelectModelData

-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
ALTER PROCEDURE SelectDataReader(
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT *,
	CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NoRead') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
	FROM(
		SELECT *, 
		ABS(Q0.grossWeight*1000 - Q0.grossWeightDefine*1000) AS 'actualDifferenceVolume',
		Q0.toLerance/1000 AS 'allowableVolumeDifference'--(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
		FROM(
			SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
			FROM DataReader DR
			INNER JOIN Model MO ON MO.modelCode = DR.modelCode
			WHERE date BETWEEN @startDate AND @endDate
		)Q0
	)Q1;
END

EXEC SelectDataReader '2024-04-01 00:00:00', '2024-05-05 23:59:59'

DROP PROCEDURE SelectDataReader


-->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
ALTER PROCEDURE SelectBarcodeQuantity(
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT ROW_NUMBER() OVER(ORDER BY DR.barcode) AS 'numOrder', DR.barcode, DR.modelCode, COUNT(DR.barcode) AS N'quantity'
	FROM DataReader DR
	WHERE DR.date BETWEEN @startDate AND @endDate
	GROUP BY DR.barcode, DR.modelCode
END

-- CALL
EXEC SelectBarcodeQuantity '2024-04-01 00:00:00', '2024-05-05 23:59:59'
-- DROP
DROP PROCEDURE SelectDataReader






CREATE PROCEDURE CountDataReader(
	@startDate DATETIME,
	@endDate DATETIME,
	@condition NVARCHAR(20)
)
AS
BEGIN
	SELECT COUNT(Q2.isReach) FROM (
	SELECT
		CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NoRead') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
		FROM(
			SELECT *, 
			ABS(Q0.grossWeight - Q0.grossWeightDefine) AS 'actualDifferenceVolume',
			(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
			FROM(
				SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
				FROM DataReader DR
				INNER JOIN Model MO ON MO.modelCode = DR.modelCode 
				WHERE date BETWEEN @startDate AND @endDate
			)Q0
		)Q1
	)Q2
	WHERE Q2.isReach = @condition;
END

EXEC CountDataReader '2024-04-01 00:00:00', '2024-05-05 23:59:59', N'Chưa đạt'


CREATE PROCEDURE CountDataReaderByModel(
	@startDate DATETIME,
	@endDate DATETIME,
	@condition NVARCHAR(20),
	@modelCode VARCHAR(20)
)
AS
BEGIN
	SELECT COUNT(Q2.isReach) FROM (
	SELECT
		CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NG') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
		FROM(
			SELECT *, 
			ABS(Q0.grossWeight - Q0.grossWeightDefine) AS 'actualDifferenceVolume',
			(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
			FROM(
				SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
				FROM DataReader DR
				INNER JOIN Model MO ON MO.modelCode = DR.modelCode 
				WHERE date BETWEEN @startDate AND @endDate AND DR.modelCode = @modelCode
			)Q0
		)Q1
	)Q2
	WHERE Q2.isReach = @condition;
END

EXEC CountDataReaderByModel'2024-04-01 00:00:00', '2024-05-05 23:59:59', N'Đạt', 'HWU1A1022'




------------------------- PROCEDURE đang dùng ------------------------------------
CREATE PROCEDURE [dbo].[CountDataReader](
	@startDate DATETIME,
	@endDate DATETIME,
	@condition NVARCHAR(20)
)
AS
BEGIN
	SELECT COUNT(Q2.isReach) AS 'count' FROM (
	SELECT
		CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NG') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
		FROM(
			SELECT *, 
			ABS(Q0.grossWeight - Q0.grossWeightDefine) AS 'actualDifferenceVolume',
			(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
			FROM(
				SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
				FROM DataReader DR
				INNER JOIN Model MO ON MO.modelCode = DR.modelCode 
				WHERE date BETWEEN @startDate AND @endDate
			)Q0
		)Q1
	)Q2
	WHERE Q2.isReach = @condition;
END
GO
--------------------------------------------------------------
CREATE PROCEDURE [dbo].[CountDataReaderByModel](
	@startDate DATETIME,
	@endDate DATETIME,
	@condition NVARCHAR(20),
	@modelCode VARCHAR(20)
)
AS
BEGIN
	SELECT COUNT(Q2.isReach) AS 'count' FROM (
	SELECT
		CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NG') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
		FROM(
			SELECT *, 
			ABS(Q0.grossWeight - Q0.grossWeightDefine) AS 'actualDifferenceVolume',
			(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
			FROM(
				SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
				FROM DataReader DR
				INNER JOIN Model MO ON MO.modelCode = DR.modelCode 
				WHERE date BETWEEN @startDate AND @endDate AND DR.modelCode = @modelCode
			)Q0
		)Q1
	)Q2
	WHERE Q2.isReach = @condition;
END
GO
--------------------------------------------------------------
CREATE PROCEDURE [dbo].[SelectBarcodeQuantity](
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT ROW_NUMBER() OVER(ORDER BY DR.barcode) AS 'numOrder', DR.barcode, DR.modelCode, COUNT(DR.barcode) AS N'quantity'
	FROM DataReader DR
	WHERE DR.date BETWEEN @startDate AND @endDate
	GROUP BY DR.barcode, DR.modelCode
END
GO
--------------------------------------------------------------
CREATE PROCEDURE [dbo].[SelectDataReader](
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT *,
	CASE WHEN (Q1.actualDifferenceVolume <= Q1.allowableVolumeDifference) AND (Q1.barcode != 'NG') THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
	FROM(
		SELECT *, 
		ABS(Q0.grossWeight*1000 - Q0.grossWeightDefine*1000) AS 'actualDifferenceVolume',
		Q0.toLerance AS 'allowableVolumeDifference'--(Q0.toLerance*Q0.grossWeight/100) AS 'allowableVolumeDifference'
		FROM(
			SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', DR.*, MO.grossWeight AS 'grossWeightDefine', MO.toLerance
			FROM DataReader DR
			INNER JOIN Model MO ON MO.modelCode = DR.modelCode
			WHERE date BETWEEN @startDate AND @endDate
		)Q0
	)Q1;
END
GO
--------------------------------------------------------------
CREATE PROCEDURE [dbo].[SelectModelData](
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
	SELECT ROW_NUMBER() OVER(ORDER BY id) AS 'numOrder', *,
	CASE WHEN MD.actualOutput >= MD.expectedOutput THEN N'Đạt' ELSE N'Chưa đạt' END AS 'isReach'
	FROM ModelData AS MD WHERE date BETWEEN @startDate AND @endDate
END
GO
--------------------------------------------------------------
CREATE PROCEDURE [dbo].[SelectOperationData](
	@startDate DATETIME,
	@endDate DATETIME
)
AS
BEGIN
SELECT ROW_NUMBER() OVER(ORDER BY Q0.id) AS 'numOrder', Q0.*,
CASE WHEN Q0.completedTime > Q0.excutionSecond THEN N'Chưa đạt' ELSE N'Đạt' END AS 'isReach'
FROM (
	SELECT OPD.*, 
	DATEDIFF(second, OPD.startTime, OPD.endTime)  AS 'completedTime', 
	DATEDIFF(second, '00:00:00', OP.excutionTime)  AS 'excutionSecond' -- thời gian cho phép
	FROM OperationData OPD
	INNER JOIN Operator OP ON OPD.modelCode = OP.modelCode AND OPD.numOperator = OP.numOperator
	WHERE OPD.date BETWEEN @startDate AND @endDate
)Q0;
END
GO


