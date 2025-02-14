using DBRepositories.Entities;
using HoaPhatApp.Classes;
using HoaPhatApp.UserControls;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoaPhatApp.Devices
{
    public enum EnumPlcStatus
    {
        CONNECTED,
        DISCONNECTED
    }

    public enum EnumPlcThread
    {
        START,
        STOP,
        ENABLE,
        DISNABLE
    }

    public class Register
    {
        public static readonly string TIME = AppSettings.GetInstance().GetTimeRegister();
        public static readonly string IGNORE = AppSettings.GetInstance().GetIgnoreRegister();
        public static readonly string IGNORE_REALLY = AppSettings.GetInstance().GetIgnoreReallyRegister();
        public static readonly string FINISHED = AppSettings.GetInstance().GetFinishedRegister();
        public static readonly string EXCEEDING = AppSettings.GetInstance().GetExceedingRegister();
        public static readonly string IMMEDIATE_TIME = AppSettings.GetInstance().GetImmediateTimeRegister();
        public static readonly string ERR_BIT = AppSettings.GetInstance().GetErrBitRegister();
        public static readonly string READY = AppSettings.GetInstance().GetReady();
        public static readonly string TOTAL_OUTPUT = AppSettings.GetInstance().GetTotalOutput();
        public static readonly string TOTAL_CURRENT_MODEL = AppSettings.GetInstance().GetCurrentModel();
        public static readonly string PRODUCT_ON_CONVEYOR = AppSettings.GetInstance().GetProductOnConveyor();
        public static readonly string READY_TRIGGER = AppSettings.GetInstance().GetReadyTrigger();
        public static readonly string COMPLETE_READING = AppSettings.GetInstance().GetCompleteReading();
        public static readonly string CAMERA_RESULT = AppSettings.GetInstance().GetCameraResult();
        public static readonly string ESCALE_RESULT = AppSettings.GetInstance().GetEscaleResult();
        public static readonly string CODE_READER = AppSettings.GetInstance().GetCodeReader();
    }

    public class DataResponse
    {
        public int iReturnCode;
        public string message;
    }

    public class PLC
    {
        private ActUtlTypeLib.ActUtlTypeClass actUtlType;
        AppSettings appSettings = AppSettings.GetInstance();

        public EnumPlcStatus PlcStatus { get; private set; }
        public EnumPlcThread PlcThread { get; private set; }

        private const short SHORTS_LENGH = 32;
        private int iNumberOfData = Properties.Settings.Default.NumOfOpeartor;
        Thread HandleReadingDataThread;

        int LineType = Properties.Settings.Default.LineType;

        public PLC()
        {
            actUtlType = new ActUtlTypeLib.ActUtlTypeClass();
        }

        private void HandleReadingData()
        {
            while (PlcStatus == EnumPlcStatus.CONNECTED && PlcThread == EnumPlcThread.START)
            {
                int[] finishData = new int[iNumberOfData];
                int[] exceedingData = new int[iNumberOfData];
                int[] immediateData = new int[iNumberOfData];
                int[] errBitData = new int[iNumberOfData];
                int totalOutput = 0;
                int totalCurrentModel = 0;
                int productOnConveyor = 0; // = 1 nếu có sản phẩm trên băng tải, PC dựa vào tín hiệu này để ra lệnh cho PLC trigger, đồng thời gửi lệnh để đọc giá trị cân
                int completeReading = 0; // nếu thanh ghi kết quả = 99 => PC dừng luồng xử lý dữ liệu
                ReadData(ref finishData, ref exceedingData, ref immediateData, errBitData, ref totalOutput, ref totalCurrentModel, ref productOnConveyor, ref completeReading);
                OnDisplayData(finishData, exceedingData, immediateData, errBitData, totalOutput, totalCurrentModel, productOnConveyor, completeReading);
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="finish"></param>
        /// <param name="exceeding"></param>
        /// <param name="immediate"></param>
        private void ReadData(ref int[] finish, ref int[] exceeding, ref int[] immediate, int[] errBitData, ref int totalOutput, ref int totalCurrentModel, ref int productOnConveyor, ref int completeReading)
        {
            if (PlcStatus == EnumPlcStatus.CONNECTED)
            {
                if(LineType == 1)
                {
                    actUtlType.GetDevice(Register.PRODUCT_ON_CONVEYOR, out productOnConveyor);
                    actUtlType.GetDevice(Register.COMPLETE_READING, out completeReading);
                }
                else if (LineType == 2)
                {
                    actUtlType.GetDevice(Register.TOTAL_OUTPUT, out totalOutput);
                    actUtlType.GetDevice(Register.TOTAL_CURRENT_MODEL, out totalCurrentModel);
                }

                for (int i = 0, j = 0; i < iNumberOfData; i++)
                {
                    actUtlType.GetDevice(string.Format(Register.FINISHED + "{0:00}", i), out finish[i]);
                    actUtlType.GetDevice(string.Format(Register.EXCEEDING + "{0:00}", i + 50), out exceeding[i]);
                    actUtlType.GetDevice(string.Format(Register.IMMEDIATE_TIME + "{0:00}", j), out immediate[i]);
                    //actUtlType.GetDevice(string.Format(Register.ERR_BIT + "{0:00}", i), out errBitData[i]);
                    j += 2;
                }

            }
        }

        /// <summary>
        /// Connect to PLC
        /// </summary>
        public void Open()
        {
            try
            {
                string stationNumberJson = appSettings.GetStationNumberString();
                int iLogicalStationNumber;
                if (GetIntValue(stationNumberJson, out iLogicalStationNumber) != true)//Convert stationNumberJson
                    return;
                actUtlType.ActLogicalStationNumber = iLogicalStationNumber;

                int iReturnCode = actUtlType.Open();

                DataResponse data = new DataResponse();
                if (iReturnCode == 0)
                {
                    data.iReturnCode = iReturnCode;
                    data.message = "Connected to PLC success.";
                    PlcStatus = EnumPlcStatus.CONNECTED;
                }
                else
                {
                    data.iReturnCode = iReturnCode;
                    data.message = "Connection failed to PLC.";
                    PlcStatus = EnumPlcStatus.DISCONNECTED;
                }
                OnDisplayStatusDevice(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Disconnect to PLC
        /// </summary>
        public void Close()
        {
            try
            {
                if(actUtlType != null)
                    actUtlType.Close();
            }

            catch (Exception e)
            {
                throw e;
            }

        }


        public void Start()
        {
            HandleReadingDataThread = new Thread(HandleReadingData);
            HandleReadingDataThread.IsBackground = true;
            HandleReadingDataThread.Start();
            PlcThread = EnumPlcThread.START;
        }

        public void Stop()
        {
            if(HandleReadingDataThread != null )
            {
                if (HandleReadingDataThread.IsAlive == true)
                {
                    PlcThread = EnumPlcThread.STOP;
                }
            }
        }


        /// <summary>
        /// Set M650 = 1 để ghi thời gian xuống PLC, M650 = 0 để KHÔNG ghi
        /// </summary>
        /// <param name="option"></param>
        /// <returns>0 if success, 1 if fail, -1 if plc not connected</returns>
        public int WriteReady(int option)
        {
            if(PlcStatus == EnumPlcStatus.CONNECTED)
            {
                int iReturnCode;
                string szDeviceName = Register.READY;
                switch (option)
                {
                    case 0:
                        iReturnCode = actUtlType.SetDevice(szDeviceName, 0);
                        break;
                    case 1:
                        iReturnCode = actUtlType.SetDevice(szDeviceName, 1);
                        break;
                    default: 
                        break;
                }
                int iData = -1;
                iReturnCode = actUtlType.GetDevice(szDeviceName, out iData);
                if (iData == 1)
                    return 1;
                else if (iData == 0){
                    return 0;
                }
                else return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// PC set D5002 = 1 để báo cho PLC biết PC đã sẵn sàng trigger
        /// </summary>
        /// <returns>Return 0 if success, 1 if fail, -1 if plc not connected</returns>
        public int WriteReadyTrigger()
        {
            if(PlcStatus == EnumPlcStatus.CONNECTED)
            {
                int iReturnCode;
                string szDeviceName = Register.READY_TRIGGER;
                iReturnCode = actUtlType.SetDevice(szDeviceName, 1);
                int iData = -1;
                iReturnCode = actUtlType.GetDevice(szDeviceName, out iData);
                if (iData == 1)
                    return 0;
                else return 1;
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <param name="option"> 0: D5004, 1: D5006, 2: D5008 </param>
        /// <returns></returns>
        public int WriteResult(int result, int option)
        {
            //Debug.WriteLine("result: " + result + ", option: " + option);
            if (PlcStatus == EnumPlcStatus.CONNECTED)
            {
                int iReturnCode;
                string szDeviceName = string.Empty;
                if (option == 0)
                    szDeviceName = Register.COMPLETE_READING;
                else if(option == 1)
                    szDeviceName = Register.CAMERA_RESULT;
                else if(option == 2)
                    szDeviceName = Register.ESCALE_RESULT;

                switch (result)
                {
                    case 1:
                        iReturnCode = actUtlType.SetDevice(szDeviceName, 1);
                        break;
                    case 99:
                        iReturnCode = actUtlType.SetDevice(szDeviceName, 99);
                        break;
                    default: break;
                }
                int iData = -1;
                iReturnCode = actUtlType.GetDevice(szDeviceName, out iData);
                if (iData == 1 || iData == 99)
                    return 0;
                else return 1;
            }
            else
            {
                return -1;
            }

        }

        public void WriteCodeReader(int codeReaderType)
        {
            if(PlcStatus == EnumPlcStatus.CONNECTED)
            {
                int iReturnCode;
                string szDeviceName = Register.CODE_READER;
                iReturnCode = actUtlType.SetDevice(szDeviceName, codeReaderType);
            }
        }

        /// <summary>
        /// Set the excutionTime and the ignore
        /// </summary>
        /// <param name="data">is the list which is get from database</param>
        /// <param name="readyOptions"></param>
        /// <returns></returns>
        public int WriteTimeAndIgnore(List<Operator> data, int readyOptions = 1)
        {
            int iReturnCode = 0;
            string szDeviceName = Register.TIME;

            short[] arrTimeValue = new short[iNumberOfData*2];
            bool[] arrBitIgnore = new bool[iNumberOfData];
            short[] arrIgnoreValue = new short[2];

            try
            {
                //Get data
                for (int i = 0; i < data.Count; i++)
                {
                    arrTimeValue[i*2] = (short)(data[i].ExcutionTime.TotalSeconds*10);
                    arrBitIgnore[i] = data[i].IsIgnore;
                }
                //Convert 
                arrIgnoreValue = ShortsFormBits(arrBitIgnore);

                //write down to plc 
                int iData = WriteReady(readyOptions);

                if (iData == 1)
                {
                    iReturnCode = actUtlType.WriteDeviceBlock2(szDeviceName, iNumberOfData*2, ref arrTimeValue[0]);
                    szDeviceName = Register.IGNORE;
                    iReturnCode = actUtlType.WriteDeviceBlock2(szDeviceName, iNumberOfData, ref arrIgnoreValue[0]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iReturnCode;
        }

        public int ReadLockStation( ref bool[] arrDataBit)
        {
            int iReturnCode;
            string szDeviceName = Register.IGNORE_REALLY;
            short[] arrDeviceValue = new short[2];

            try
            {
                iReturnCode = actUtlType.ReadDeviceBlock2(szDeviceName, iNumberOfData, out arrDeviceValue[0]);
                arrDataBit = ToBitArray(arrDeviceValue, SHORTS_LENGH);
                return iReturnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetTotalOutput()
        {
            try
            {
                if (PlcStatus == EnumPlcStatus.CONNECTED)
                {
                    actUtlType.SetDevice(Register.TOTAL_OUTPUT, 0);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public bool ResetCurrentModel()
        {
            try
            {
                if (PlcStatus == EnumPlcStatus.CONNECTED)
                {
                    actUtlType.SetDevice(Register.TOTAL_CURRENT_MODEL, 0);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        /// <summary>
        /// Đọc trạng thái thực hiện của các công đoạn, 1: Hoàn thành. 0: đang thực hiện
        /// </summary>

        public int ReadFinish(ref bool[] arrFinishBit)
        {
            int iReturnCode;
            short[] arrDeviceValue = new short[2];       
            try
            {
                iReturnCode = actUtlType.ReadDeviceBlock2(Register.FINISHED, SHORTS_LENGH, out arrDeviceValue[0]);
                arrFinishBit =  ToBitArray(arrDeviceValue, SHORTS_LENGH);
                return iReturnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /****** CHÚ Ý: dùng các toán tử thao tác với bit, phần mềm chạy 1 thời gian sẽ tự động tắt. chưa rõ nguyên nhân *****/
        public bool[] ToBitArray(short[] shorts, int length)
        {
            bool[] arrDataBit = new bool[SHORTS_LENGH];
            if (length > shorts.Length * 16) throw new ArgumentException($"Not enough data in bytes to return {length} bits.", nameof(shorts));
            int result = 0;
            result = (ushort)shorts[1] << 16 | (ushort)shorts[0];
            BitArray bitArr = new BitArray(new int[] { result });
            for (short i = 0; i < length; i++) arrDataBit[i] = bitArr[i];
            return arrDataBit;
        }

        /// <summary>
        /// Converts a bit array to short array
        /// </summary>
        /// <param name="data">This is a array bit with a lengh not exceeding 2 shorts (32 bits)</param>
        /// <returns></returns>
        private short[] ShortsFormBits(bool[] data)
        {
            short[] res = new short[2];
            for (short i = 0; i < data.Length; i++)
            {
                if (i >= 0 && i < 16)
                {
                    if (data[i])
                    {
                        res[0] |= (short)(1 << i);
                    }
                }
                if (i >= 16 && i < data.Length)
                {
                    if (data[i])
                    {
                        res[1] |= (short)(1 << i - 16);
                    }
                }
            }
            return res;
        }

        private bool GetIntValue(string sourceOfIntValue, out int iGottenIntValue)
        {
            iGottenIntValue = 0;
            try
            {
                //Get the value as 32bit integer from a string
                iGottenIntValue = Convert.ToInt32(sourceOfIntValue);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;//Normal End
        }

        /// <summary>
        /// Show status of PLC is connected or disconnected
        /// </summary>
        /// <param name="data"></param>
        public delegate void DisplayDeviceStatus(DataResponse data);
        public static event DisplayDeviceStatus OnDisplayStatusDevice;

        /// <summary>
        /// Transmit the data read from PLC
        /// </summary>
        /// <param name="finishData"></param>
        /// <param name="exceedingData"></param>
        /// <param name="immediateData"></param>
        public delegate void DisplayData(int[] finishData, int[] exceedingData, int[] immediateData, int[] errBitData, int totalOutput, int totalCurrentModel, int productOnConveyor, int completeReading);
        public static event DisplayData OnDisplayData;
    }
}
