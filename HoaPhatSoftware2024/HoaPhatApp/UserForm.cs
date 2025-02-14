using DBRepositories.Entities;
using DBServices;
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
    public partial class UserForm : Form
    {
        AccountService accountService = AccountService.GetInstance();
        public UserForm()
        {
            InitializeComponent();
            RegisterEvent();
            DisplayDataGridView(dgvUser, SystemColors.ControlLight);
        }

        private void RegisterEvent()
        {
            Load += UserForm_Load;
            dgvUser.CellClick += DgvUser_CellClick;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Account newAccount = new Account();
            newAccount.UserName = dgvUser.Rows[rowId].Cells["userName"].Value.ToString();

            if(MessageBox.Show("Bạn muốn xóa tài khoản "+ newAccount.UserName + "", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                accountService.Delete(newAccount.UserName);
                RefreshDgv();
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            Account newAccount = new Account();
            newAccount.AccountName = dgvUser.Rows[rowId].Cells["accountName"].Value.ToString();
            newAccount.UserName = dgvUser.Rows[rowId].Cells["userName"].Value.ToString();
            newAccount.PassWord = dgvUser.Rows[rowId].Cells["passWord"].Value.ToString();
            newAccount.Role = byte.Parse(dgvUser.Rows[rowId].Cells["role"].Value.ToString());

            Account accountLogin = accountService.GetUserName(newAccount.UserName);
            if (accountLogin == null)
            {
                accountService.Update(newAccount);
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Đã tồn tại tên đăng nhập "+ newAccount.UserName + "", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshDgv();
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Account newAccount = new Account();
            newAccount.AccountName = dgvUser.Rows[rowId].Cells["accountName"].Value.ToString();
            newAccount.UserName = dgvUser.Rows[rowId].Cells["userName"].Value.ToString();
            newAccount.PassWord = dgvUser.Rows[rowId].Cells["passWord"].Value.ToString();
            newAccount.Role = byte.Parse(dgvUser.Rows[rowId].Cells["role"].Value.ToString());

            Account accountLogin = accountService.GetUserName(newAccount.UserName);
            if(accountLogin == null)
            {
                accountService.Create(newAccount);
                RefreshDgv();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        int rowId;
        private void DgvUser_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            rowId = e.RowIndex;
        }

        private void UserForm_Load(object? sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            List<Account> lst = accountService.GetAll();
            Account newAccount = new Account();
            lst.Add(newAccount);
            dgvUser.DataSource = lst;
        }

        private void DisplayDataGridView(DataGridView dgv, Color color)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = color;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }
    }
}
