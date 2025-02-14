using HoaPhatApp.Classes;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaPhatApp.Devices
{
    public class EScale
    {
        private SerialPort serialPort;
        private string DataReceied = string.Empty;
        AppSettings appSettings = AppSettings.GetInstance();
        public EScale() 
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
        }

        public void Open()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = appSettings.GetComPort();
                    serialPort.BaudRate = Convert.ToInt32("9600");
                    serialPort.DataBits = Convert.ToInt32("8");
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        DataResponse dataRes = new DataResponse();
                        dataRes.iReturnCode = 0;
                        dataRes.message = "EScale Opened";
                        OnDisplayStatusEscale(dataRes);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                if (!serialPort.IsOpen)
                {
                    DataResponse dataRes = new DataResponse();
                    dataRes.iReturnCode = 1;
                    dataRes.message = "EScale Closed";
                    OnDisplayStatusEscale(dataRes);
                }
            }
        }

        public void SendData()
        {
            if (serialPort.IsOpen)
            {
                string data = string.Format("{0}{1}{2}", "\x02", "A", "\x03");
                serialPort.Write(data);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(30);
                DataReceied = serialPort.ReadExisting();
                string[] DataReceiedArr1 = DataReceied.Split(':');
                string DataReceiedArr2 = DataReceiedArr1[1].Substring(0, 7);
                if (DataReceied != string.Empty)
                {
                    HandleDataReceived.EscaleDataReceivedQueue.Add(DataReceiedArr2);
                    OnDisplayResultEscale(DataReceiedArr2);
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        public delegate void DisplayResultEScale(string result);
        public static DisplayResultEScale OnDisplayResultEscale;

        public delegate void DisplayStatusEScale(DataResponse dtRes);
        public static DisplayStatusEScale OnDisplayStatusEscale;

    }
}
