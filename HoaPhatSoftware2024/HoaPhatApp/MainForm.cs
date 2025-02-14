
using DBRepositories.Entities;
using HoaPhatApp.Classes;
using HoaPhatApp.Devices;
using HoaPhatApp.Properties;
using HoaPhatApp.TCPServer;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using static HoaPhatApp.MainForm;

namespace HoaPhatApp
{
    public partial class MainForm : Form
    {
        //FORMS
        Form currentForm = null;
        HomeForm homeForm = null;
        HistoryForm historyForm = null;
        ErrorForm errorForm = null;
        SettingForm settingForm = null;

        public static Account accoutLogin;
        public static string operatorName = string.Empty;

        int LineType = Properties.Settings.Default.LineType;

        //TCP
        Listener listener;
        Client client;
        List<Client> clientSocks = new List<Client>();

        AppSettings appSettings = AppSettings.GetInstance();
        System.Windows.Forms.Timer tmrDateTime;

        public MainForm()
        {
            InitializeComponent();
            InitializeForms();
            RegisterEvents();
            if(LineType == 1)
            {
                InitializeSocket();
            }
        }


        #region >> FORMS

        #region     > Methods
        private void RegisterEvents()
        {
            Load += MainForm_Load;
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;

            tmrDateTime = new System.Windows.Forms.Timer();
            tmrDateTime.Interval = 1000;
            tmrDateTime.Tick += TmrDateTime_Tick;
            tmrDateTime.Start();

            picLogo.Click += PicLogo_Click;
            btnHome.Click += BtnHome_Click;
            btnReport.Click += BtnReport_Click;
            btnSetting.Click += BtnSetting_Click;
            btnHistory.Click += BtnHistory_Click;
            btnExtension.Click += BtnExtension_Click;
            btnUser.Click += BtnUser_Click;
            //btnAppSettings.Click += BtnAppSettings_Click;

            //Register event open form report from reportform
            HistoryForm.FormOpened += OpenForm;

            PLC.OnDisplayStatusDevice += PLC_OnDisplayStatusDevice;
            EScale.OnDisplayStatusEscale += Escale_OnDisplayStatusEscale;
            HandleDataReceived.OnDisplayStatus += HandleDataReceived_OnDisplayStatus;
        }

        private void BtnUser_Click(object? sender, EventArgs e)
        {
            if(accoutLogin.Role == 1)
            {
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chức năng chỉ dành cho tài khoản Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TmrDateTime_Tick(object? sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PLC_OnDisplayStatusDevice(DataResponse data)
        {
            if(data.iReturnCode == 0)
            {
                Invoke((MethodInvoker)delegate
                {
                    cpnPlcStatus.BackColor = Color.LightGreen;
                    lbPlcStatus.Text = "Đã kết nối";
                    lbReady.Text = data.message;
                    lbReady.ForeColor = Color.Black;
                });

            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    cpnPlcStatus.BackColor = Color.Red;
                    lbPlcStatus.Text = "Lỗi";
                    lbReady.Text = data.message + " " + String.Format("0x{0:x8}", data.iReturnCode).ToUpper();
                    lbReady.ForeColor = Color.Black;
                });
            }
        }

        private void Escale_OnDisplayStatusEscale(DataResponse data)
        {
            if (data.iReturnCode == 0)
            {
                Invoke((MethodInvoker)delegate
                {
                    cpnLoadCellStatus.BackColor = Color.LightGreen;
                    lbLoadCellStatus.Text = "Đã kết nối";
                    lbReady.Text = data.message;
                    lbReady.ForeColor = Color.Black;
                });

            }
            else if (data.iReturnCode == 1)
            {
                Invoke((MethodInvoker)delegate
                {
                    cpnLoadCellStatus.BackColor = Color.Gray;
                    lbLoadCellStatus.Text = "Đã kết nối";
                    lbReady.Text = data.message;
                    lbReady.ForeColor = Color.Black;

                });
            }
        }

        private void HandleDataReceived_OnDisplayStatus(EnumProcessingData status)
        {
            if (status == EnumProcessingData.START)
            {
                Invoke((MethodInvoker)delegate
                {
                    lbReady.Text = "Bắt đầu xử lý dữ liệu.";
                    lbReady.ForeColor = Color.Green;
                });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    lbReady.Text = "Kết thúc xử lý dữ liệu.";
                    lbReady.ForeColor = Color.Red;
                });
            }
        }
        private void InitializeForms()
        {
            homeForm = new HomeForm();
            historyForm = new HistoryForm();
            settingForm = new SettingForm();
            errorForm = new ErrorForm();

            accoutLogin = new Account();
        }

        private void OpenForm(Form frm)
        {
            currentForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.pnMainBody.Controls.Add(frm);
            this.pnMainBody.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void DefaultSettings()
        {
            if(Properties.Settings.Default.ErrEventNewsletter != null)
            {
                Properties.Settings.Default.ErrEventNewsletter.Clear();
            }
            string[] ErrEventNewsletter = new string[Properties.Settings.Default.NumOfOpeartor];
            for (int i = 0; i < ErrEventNewsletter.Length; i++)
            {
                ErrEventNewsletter[i] = "0";
            }
            Properties.Settings.Default.ErrEventNewsletter.AddRange(ErrEventNewsletter);
            Properties.Settings.Default.Save();
        }
        private void InitializeSettings()
        {
            if (Properties.Settings.Default.ErrEventNewsletter == null)
            {
                string[] ErrEventNewsletter = new string[Properties.Settings.Default.NumOfOpeartor];
                for (int i = 0; i < ErrEventNewsletter.Length; i++)
                {
                    ErrEventNewsletter[i] = "0";
                }
                Properties.Settings.Default.ErrEventNewsletter.AddRange(ErrEventNewsletter);
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #region     > Events

        private void MainForm_Load(object? sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbLineName.Text = Properties.Settings.Default.LineName;
            lbUserName.Text = accoutLogin.AccountName;
            if(accoutLogin.Role == 1)
            {
                lbRole.Text = "Administrator";
            }
            else
            {
                lbRole.Text = "User";
            }
            InitializeSettings();
            OpenForm(homeForm);
            if(LineType == 1) //Chuyền chính
            {
                //TCP/IP
                listener.Start();
                lbPortName.Text = appSettings.GetPortServer().ToString();
                lbPortName.ForeColor = Color.Navy;
                this.lbPortName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }

            if(LineType == 2) //  Chuyền phụ
            {
                lbReady.Visible = false;
            }

        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if(homeForm != null)
            {
                homeForm.Close();
            }

            if (LineType == 1)
            {
                //TCP
                if (client == null)
                    return;
                client.Close();
            }
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void BtnAppSettings_Click(object? sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void PicLogo_Click(object? sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Visible = false;
            }
        }

        private void BtnExtension_Click(object? sender, EventArgs e)
        {
            if (pnLeft.Width == 230 && btnExtension.Text == "<")
            {
                pnLeft.Size = new Size(60, 565);
                btnExtension.Text = ">";
            }
            else if (pnLeft.Width == 60 && btnExtension.Text == ">")
            {
                pnLeft.Size = new Size(230, 565);
                btnExtension.Text = "<";
            }
        }

        private void BtnSetting_Click(object? sender, EventArgs e)
        {
            OpenForm(settingForm);
            btnHome.BackColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            btnSetting.BackColor = Color.FromArgb(0, 152, 210);
            lbTittle.Text = "Thiết lập";
        }

        private void BtnHistory_Click(object? sender, EventArgs e)
        {
            OpenForm(historyForm);
            btnHome.BackColor = Color.Transparent;
            btnHistory.BackColor = Color.FromArgb(0, 152, 210);
            btnReport.BackColor = Color.Transparent;
            btnSetting.BackColor = Color.Transparent;
            lbTittle.Text = "Cơ sở dữ liệu";
        }

        private void BtnReport_Click(object? sender, EventArgs e)
        {
            OpenForm(ReportForm.GetInstance());
            btnHome.BackColor = Color.Transparent;
            btnHistory.BackColor = Color.Transparent;
            btnReport.BackColor = Color.FromArgb(0, 152, 210);
            btnSetting.BackColor = Color.Transparent;
            lbTittle.Text = "Báo cáo sản xuất";
        }

        private void BtnHome_Click(object? sender, EventArgs e)
        {
            if(homeForm == null)            
                homeForm = new HomeForm();
            OpenForm(homeForm);
            btnHome.BackColor = Color.FromArgb(0, 152, 210);
            btnHistory.BackColor = Color.Transparent;
            btnReport.BackColor = Color.Transparent;
            btnSetting.BackColor = Color.Transparent;
            lbTittle.Text = "Trang chủ";
        }
        #endregion

        #endregion


        #region >> TCP

        private void InitializeSocket()
        {
            int port = appSettings.GetPortServer();
            listener = new Listener(port, lbServerStatus);
            listener.SocketAccepted += new Listener.SocketAcceptedHandler(ListenerSocketAccepted);
        }

        private void ListenerSocketAccepted(Socket e)
        {
            client = new Client(e);
            client.Received += new Client.ClientReceivedHandler(ClientReceived);
            client.Disconnected += new Client.ClientDisconnectedHandler(ClientDisconnected);
            clientSocks.Add(client);//add to list sock


            Invoke((MethodInvoker)delegate
            {
                lbReady.Text = "Connected to Camera.";
                lbReady.ForeColor = Color.Black;
                lbCameraStatus.Text = "Đã kết nối";
                cpnCameraStatus.BackColor = Color.LightGreen;
                listBox1.Items.Add(string.Format("DateTime: {0} | Client: {1} | Data: {2}", DateTime.Now.ToString(), client.IPEndPoint, "Connected"));
            });
        }

        private void ClientDisconnected(Client sender)
        {
            Invoke((MethodInvoker)delegate
            {
                lbReady.Text = "Camera disconnected";
                lbReady.ForeColor = Color.Black;
                lbCameraStatus.Text = "Chưa kết nối";
                cpnCameraStatus.BackColor = Color.Gray;
                listBox1.Items.Add(string.Format("DateTime: {0} | Client: {1} | Data: {2}", DateTime.Now.ToString(), sender.IPEndPoint, "Disconnected"));
                for (int i = 0; i < clientSocks.Count; i++)
                {
                    Client client = clientSocks[i];
                    if (client.IPEndPoint == sender.IPEndPoint)
                    {
                        clientSocks.RemoveAt(i); // remove to list sock
                        break;
                    }
                }
            });
        }

        int countDisplayCameraResult = 0;
        private void ClientReceived(Client sender, byte[] data)
        {
            string DataReceived;
            DataReceived = Encoding.Default.GetString(data);

            CameraDataResponse response = new CameraDataResponse();
            response.Barcode = DataReceived;
            string CurrentModelCode = HomeForm.CurrentModelCode;
            if (CurrentModelCode == string.Empty)
            {
                Invoke((MethodInvoker)delegate
                {
                    listBox1.Items.Add(string.Format("DateTime: {0} | Client: {1} | Data: {2}", DateTime.Now.ToString(), sender.IPEndPoint, DataReceived + " - " + "CurrentModelCode is Empty"));
                });
                return;
            }
            response.ModelCode = CurrentModelCode;

            countDisplayCameraResult++;
            HandleDataReceived.CameraDataReceivedQueue.Add(response);
            if(countDisplayCameraResult == 2)
            {
                for(int i = 0; i < HandleDataReceived.CameraDataReceivedQueue.Count; i++)
                {
                    if (HandleDataReceived.CameraDataReceivedQueue[i].Barcode != "NoRead")
                    {
                        OnDisplayResultCamera(DataReceived);
                        break;
                    }
                    else
                    {
                        OnDisplayResultCamera(DataReceived);
                    }
                }
                countDisplayCameraResult = 0;
            }

            Invoke((MethodInvoker)delegate
            {
                listBox1.Items.Add(string.Format("DateTime: {0} | Client: {1} | Data: {2}", DateTime.Now.ToString(), sender.IPEndPoint, DataReceived + "-" + CurrentModelCode));
            });
        }

        public delegate void DisplayResultCamera(string result);
        public static event DisplayResultCamera OnDisplayResultCamera;

        #endregion

    }
}
