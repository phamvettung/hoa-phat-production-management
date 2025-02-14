namespace HoaPhatApp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            dgvUser = new Zuby.ADGV.AdvancedDataGridView();
            accountName = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            passWord = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            lbUserName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.Fixed3D;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { accountName, userName, passWord, role });
            dgvUser.FilterAndSortEnabled = true;
            dgvUser.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvUser.Location = new Point(12, 58);
            dgvUser.MaxFilterButtonImageHeight = 23;
            dgvUser.Name = "dgvUser";
            dgvUser.RightToLeft = RightToLeft.No;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(694, 380);
            dgvUser.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvUser.TabIndex = 0;
            // 
            // accountName
            // 
            accountName.DataPropertyName = "accountName";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountName.DefaultCellStyle = dataGridViewCellStyle1;
            accountName.HeaderText = "Tên tài khoản";
            accountName.MinimumWidth = 24;
            accountName.Name = "accountName";
            accountName.SortMode = DataGridViewColumnSortMode.Programmatic;
            accountName.Width = 200;
            // 
            // userName
            // 
            userName.DataPropertyName = "userName";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userName.DefaultCellStyle = dataGridViewCellStyle2;
            userName.HeaderText = "Tên đăng nhập";
            userName.MinimumWidth = 24;
            userName.Name = "userName";
            userName.SortMode = DataGridViewColumnSortMode.Programmatic;
            userName.Width = 150;
            // 
            // passWord
            // 
            passWord.DataPropertyName = "passWord";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passWord.DefaultCellStyle = dataGridViewCellStyle3;
            passWord.HeaderText = "Mật khẩu";
            passWord.MinimumWidth = 24;
            passWord.Name = "passWord";
            passWord.SortMode = DataGridViewColumnSortMode.Programmatic;
            passWord.Width = 150;
            // 
            // role
            // 
            role.DataPropertyName = "role";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            role.DefaultCellStyle = dataGridViewCellStyle4;
            role.HeaderText = "Quyền truy cập";
            role.MinimumWidth = 24;
            role.Name = "role";
            role.SortMode = DataGridViewColumnSortMode.Programmatic;
            role.Width = 150;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Black;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(616, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Silver;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.System;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(520, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 35);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Silver;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(424, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(174, 9);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(28, 30);
            lbUserName.TabIndex = 10;
            lbUserName.Text = "...";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 448);
            Controls.Add(lbUserName);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvUser;
        private DataGridViewTextBoxColumn accountName;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn passWord;
        private DataGridViewTextBoxColumn role;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Label lbUserName;
    }
}