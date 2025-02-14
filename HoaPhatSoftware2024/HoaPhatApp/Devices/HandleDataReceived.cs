using DBRepositories.Entities;
using DBServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HoaPhatApp.Devices.HandleDataReceived;

namespace HoaPhatApp.Devices
{
    public class CameraDataResponse
    {
        public string ModelCode { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
    }
    public enum EnumProcessingData
    {
        START,
        STOP,
        OK,
        NG,
        EMPTY,
        ACTIVE,
        INACTIVE
    }
    /// <summary>
    /// This class to handle data received of Camera(over TCP) and Escale (over serial port)
    /// </summary>
    public class HandleDataReceived
    {
        private static HandleDataReceived instance;

        /// <summary>
        /// The message queue contain all the message received of Camera
        /// </summary>
        public static List<CameraDataResponse> CameraDataReceivedQueue { get; set; } = new List<CameraDataResponse>();
        /// <summary>
        /// The message queue contain all the message received of Escale
        /// </summary>
        public static List<string> EscaleDataReceivedQueue { get; set; } = new List<string>();

        private Thread HandleDataThread;
        public static EnumProcessingData ProcessingData { get; set;} = EnumProcessingData.STOP;
        DataReaderService dataReaderService = DataReaderService.GetInstance();
        ServiceExtension serviceExtension = ServiceExtension.GetInstance();
        ModelService modelService = ModelService.GetInstance();

        private EnumProcessingData CameraStatus { get; set; }

        private HandleDataReceived()
        {
            CameraStatus = EnumProcessingData.ACTIVE;
            AuthenForm.ActiveCamera += AuthenForm_ActiveCamera;
        }

        public static HandleDataReceived GetInstance()
        {
            if(instance == null)
                instance = new HandleDataReceived();
            return instance;
        }

        public void Start()
        {
            if (CameraDataReceivedQueue.Count > 0)
                CameraDataReceivedQueue.Clear();
            if (EscaleDataReceivedQueue.Count > 0)
                EscaleDataReceivedQueue.Clear();

            HandleDataThread = new Thread(HandleDataQueue);
            HandleDataThread.IsBackground = true;
            HandleDataThread.Start();
            ProcessingData = EnumProcessingData.START;
            OnDisplayStatus(ProcessingData);
        }

        public void Stop()
        {
            if(HandleDataThread != null)
            {
                if (HandleDataThread.IsAlive == true)
                {
                    ProcessingData = EnumProcessingData.STOP;
                    OnDisplayStatus(ProcessingData);
                }
            }         
        }

        private void HandleDataQueue()
        {
            int countTimeout = 0;
            string barcode = "NoRead", modelCode = string.Empty;
            float grossWeight = 0;

            while (ProcessingData != EnumProcessingData.STOP)
            {
                if (CameraDataReceivedQueue.Count > 1 && EscaleDataReceivedQueue.Count > 0)
                {
                    try
                    {
                        //Lấy barcode OK từ CameraDataReceivedQueue
                        for (int i = 0; i < CameraDataReceivedQueue.Count; i++)
                        {
                            if (CameraDataReceivedQueue[i].Barcode != "NoRead")
                            {
                                barcode = CameraDataReceivedQueue[i].Barcode;
                                modelCode = CameraDataReceivedQueue[0].ModelCode;
                                break;
                            }
                        }
                       
                        //Lấy giá trị cân từ EscaleDataReceivedQueue
                        grossWeight = float.Parse(EscaleDataReceivedQueue[0]);

                        if (barcode != "NoRead") 
                        {                          
                            ProcessingData = EnumProcessingData.STOP;
                            //Prepare data to save
                            DataReader dataReader = new DataReader();
                            dataReader.Date = DateTime.Now;
                            dataReader.ModelCode = modelCode;
                            dataReader.Barcode = barcode;
                            dataReader.GrossWeight = grossWeight;
                            //Show result to HomeForm
                            OnDisplayCounterAndResult(dataReader, ProcessingResult(dataReader));
                        }
                        else
                        {

                        }                   
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {

                    }
                }
                Thread.Sleep(100);

                countTimeout++;
                if (countTimeout >= 50) //5s
                {
                    if(barcode == string.Empty || modelCode == string.Empty)
                    {
                        barcode = "NoRead"; modelCode = "NOREAD";
                    }

                    ProcessingData = EnumProcessingData.STOP;
                    //Prepare data to save
                    DataReader dataReader = new DataReader();
                    dataReader.Date = DateTime.Now;
                    dataReader.ModelCode = modelCode;
                    dataReader.Barcode = barcode;
                    dataReader.GrossWeight = grossWeight;
                    dataReader.UserName = MainForm.accoutLogin.AccountName;
                    dataReader.OperatorName = MainForm.operatorName;
                    //Show result to HomeForm
                    OnDisplayCounterAndResult(dataReader, ProcessingResult(dataReader));
                }

            }

            if(CameraDataReceivedQueue.Count > 0)
            {
                CameraDataReceivedQueue.Clear();
            }
                
            if (EscaleDataReceivedQueue.Count > 0)
            {
                EscaleDataReceivedQueue.Clear();
            }
        }

        private EnumProcessingData ProcessingResult(DataReader dataReader)
        {
            bool resultCamera = false, resultEscale = false;
            int res = modelService.GetResultEscale(dataReader.ModelCode, dataReader.GrossWeight);
            if (res == 0)
            {
                resultEscale = true;
                OnDisplayResult(2, EnumProcessingData.OK);
            }
            else
            {
                resultEscale = false;
                OnDisplayResult(2, EnumProcessingData.NG);
            }
            if(dataReader.Barcode != "NoRead")
            {
                resultCamera = true;
                OnDisplayResult(1, EnumProcessingData.OK);
            }
            else
            {
                if(this.CameraStatus != EnumProcessingData.INACTIVE)
                {
                    resultCamera = false;
                    OnDisplayResult(1, EnumProcessingData.NG);
                }
                else
                {
                    resultCamera = true;
                    OnDisplayResult(1, EnumProcessingData.OK);
                }
            }

            if (resultCamera&&resultEscale)
                return EnumProcessingData.OK;
            else
                return EnumProcessingData.NG;
        }

        #region Events
        private void AuthenForm_ActiveCamera(EnumProcessingData status)
        {
            this.CameraStatus = status;
        }

        #endregion


        public delegate void DisplayCounterAndResult(DataReader dataSaved, EnumProcessingData result);
        public static event DisplayCounterAndResult OnDisplayCounterAndResult;

        public delegate void DisplayStatus(EnumProcessingData status);
        public static event DisplayStatus OnDisplayStatus;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option">0: D5004 (Camer +Can), 1: D5006 (Camera), 2: D5008 (cân)</param>
        /// <param name="result"></param>
        public delegate void DisplayResult(int option, EnumProcessingData result);
        public static event DisplayResult OnDisplayResult;
    }
}
