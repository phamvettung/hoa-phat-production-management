# PHẦN MỀM QUẢN LÝ SẢN XUẤT CHO DÂY CHUYỀN LẮP RÁP HÒA PHÁT
![Hoa phat production management](/assets/dashboard.jpg)
### NGUYÊN LÝ HOẠT ĐỘNG
Trên dây chuyền sản xuất được chia thành nhiều công đoạn lắp ráp, người công nhân được phép thực hiện trong 1 khoảng thời gian. Sau khi thực hiện lắp ráp xong, người công nhân nhấn nút hoàn hoàn để máy được chuyển đến các công đoạn tiếp theo. Trường hợp vượt quá thời gian cho phép sẽ có đèn, còi cảnh báo và hiển thị cảnh báo trên phần mềm.
### CÁC TÍNH NĂNG
- Hiển thị Sản lượng mục tiêu, thực tế của Kế hoạch Sản xuất, Tỷ lệ hoàn thành, Tổng thời gian sản xuất trên phần mềm và lưu lại sản lượng thực tế trong ngày.
- Hiển thị 04 trạng thái làm việc của công đoạn: Hoàn thành (màu xanh), Đang thực hiện (màu vàng), Chậm (màu đỏ), Bỏ qua (màu xám). Lưu lịch sử thời gian thao tác của mỗi công đoạn và đưa ra đánh giá "Đạt" hoặc "Chưa đạt".
- Quản lý Model: thêm, sửa, xóa, cài đặt thời gian thực hiện cho công đoạn, bỏ qua công đoạn của từng Model.
- Cài đặt khối lượng cho từng Model và sai số cho phép.
- Thu thập số serial (barcode dán trên máy) và khối lượng. Đưa ra kết quả OK/NG do khối lượng hoặc không đọc được serial và gửi tín hiệu đèn xanh (OK), đèn đỏ (NG) xuống băng chuyền.
- Kết nối với Bộ điều khiển PLC Mitsubishi.
- Kết nối với Đầu đọc mã vạch Hikrobot qua kết nối TCP/IP.
- Kết nối với Đầu đọc Cân qua truyền thông RS232.
### CÁC CÔNG NGHỆ SỬ DỤNG
- Windows Forms, Entity Framework, MS SQL Server
- Ngôn ngữ: C#
