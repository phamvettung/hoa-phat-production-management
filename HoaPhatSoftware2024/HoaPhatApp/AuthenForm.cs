using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Devices;
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
    public partial class AuthenForm : Form
    {
        AccountService accountService = AccountService.GetInstance();
        public EnumProcessingData CameraStatus { get; set; }

        public AuthenForm()
        {
            CameraStatus = EnumProcessingData.ACTIVE;
            InitializeComponent();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            Load += AuthenForm_Load;
            btnAuthen.Click += BtnAuthen_Click;
        }

        private void AuthenForm_Load(object? sender, EventArgs e)
        {
            
        }

        private void BtnAuthen_Click(object? sender, EventArgs e)
        {
            if(txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassWord.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account account = accountService.GetAccount(txtUserName.Text, txtPassWord.Text);
            if(account == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if(account.Role == 1)
                {
                    ActiveCamera(CameraStatus);
                    MessageBox.Show("Đã lưu cài đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chức năng chỉ dành cho tài khoản Administrators", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        public delegate void ActivingCameraDelegate(EnumProcessingData status);
        public static event ActivingCameraDelegate ActiveCamera;
    }
}
