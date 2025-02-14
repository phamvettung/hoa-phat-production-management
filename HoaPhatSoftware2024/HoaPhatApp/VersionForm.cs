using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaPhatApp
{
    public partial class VersionForm : Form
    {
        AppSettings appSettings = AppSettings.GetInstance();
        AccountService accountService = AccountService.GetInstance();
        ProductionOrderService productionOrderService = ProductionOrderService.GetInstance();
        ModelDataService modelDataService = ModelDataService.GetInstance();
        int LineType = Properties.Settings.Default.LineType;
        public VersionForm()
        {
            InitializeComponent();
            //lbAllRightsReserved.Text = "Phần mềm QLSX Hòa Phát là sản phẩm của Công ty Cổ phần Tập đoàn Kỹ thuật và Công Nghiệp Việt Nam - INTECH GROUP";
            RegisterEvents();

        }

        private void RegisterEvents()
        {
            Load += VersionForm_Load;
            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            if(txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPassWord.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (txtOperatorName.Text == string.Empty && Properties.Settings.Default.LineType == 2)
            //{
            //    MessageBox.Show("Bạn chưa nhập tên người vận hành trạm đọc cân, serial", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

                Account account = accountService.GetAccount(txtUserName.Text.Trim(), txtPassWord.Text.Trim());
            if (account == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DefaultSettings();
            Properties.Settings.Default.LineName = txtLineName.Text.ToUpper().Trim();
            if(cboLineType.SelectedIndex == 0 )
            {
                Properties.Settings.Default.LineType = 1; // 1. Chuyền chính (24 công đoạn)
                Properties.Settings.Default.NumOfOpeartor = 24;
            }
            else if(cboLineType.SelectedIndex == 1)
            {
                Properties.Settings.Default.LineType = 2; // 2. Chuyền phụ (17 công đoạn)
                Properties.Settings.Default.NumOfOpeartor = 17;
            }
            Properties.Settings.Default.Save();

            this.Hide();
            List<ProductionOrder> lstOrder = productionOrderService.GetAll();
            if(lstOrder.Count > 0)
            {
                string mes = string.Format("Đã lưu thông tin cài đặt:\n-Tên chuyền: {0}\n-Số công đoạn: {1}.\n<<============================>>\nBạn có muốn tiếp tục Lệnh sản xuất?\n-Chọn YES để tiếp tục Lệnh sản xuất\n-Chọn NO để tạo Lệnh sản xuất mới", Properties.Settings.Default.LineName, Properties.Settings.Default.NumOfOpeartor);
                DialogResult dr = MessageBox.Show(mes, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    foreach(ProductionOrder prod in lstOrder)
                    {
                        ModelDatum modelData = new ModelDatum();
                        modelData.Date = prod.Date;
                        modelData.ModelCode = prod.ModelCode;
                        modelData.ActualOutput = prod.ActualOutput;
                        modelData.ExpectedOutput = prod.ExpectedOutput;
                        modelDataService.Create(modelData);
                    }
                    productionOrderService.DeleteAll();
                }
            }
            else
            {
                string mes = string.Format("Đã lưu thông tin cài đặt:\n-Tên chuyền: {0}\n-Số công đoạn: {1}.", Properties.Settings.Default.LineName, Properties.Settings.Default.NumOfOpeartor);
                MessageBox.Show(mes, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MainForm mainForm = new MainForm();
            MainForm.accoutLogin = account;
            MainForm.operatorName = txtOperatorName.Text;
            mainForm.ShowDialog();
            this.Close();
        }

        private void VersionForm_Load(object? sender, EventArgs e)
        {
            lbVersion.Text = appSettings.GetVersionName();
            lbDateUpgrated.Text = appSettings.GetDateUpgrated();
            txtLineName.Text = Properties.Settings.Default.LineName;
            int lineType = Properties.Settings.Default.LineType;
            if(lineType == 1)
                cboLineType.SelectedIndex = 0;
            else if(lineType == 2)
                cboLineType.SelectedIndex = 1;
        }
        
        private void DefaultSettings()
        {
            Properties.Settings.Default.LineName = string.Empty;
            Properties.Settings.Default.LineType = 0;
            Properties.Settings.Default.NumOfOpeartor = 0;
        }
    }
}
