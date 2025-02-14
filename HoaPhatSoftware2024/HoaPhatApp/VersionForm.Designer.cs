namespace HoaPhatApp
{
    partial class VersionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionForm));
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            groupBox2 = new GroupBox();
            txtPassWord = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtUserName = new TextBox();
            lbDateUpgrated = new Label();
            btnOk = new Button();
            label7 = new Label();
            lbVersion = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            cboLineType = new ComboBox();
            label3 = new Label();
            txtLineName = new RichTextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            txtOperatorName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Location = new Point(146, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(664, 2);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Location = new Point(146, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(664, 5);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Intech_logo1;
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(lbDateUpgrated);
            panel3.Controls.Add(btnOk);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lbVersion);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 462);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(559, 425);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 10;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Location = new Point(12, 414);
            panel7.Name = "panel7";
            panel7.Size = new Size(776, 2);
            panel7.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(txtOperatorName);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPassWord);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 103);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đăng nhập";
            // 
            // txtPassWord
            // 
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(137, 66);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "Nhập vào mật khẩu";
            txtPassWord.Size = new Size(250, 22);
            txtPassWord.TabIndex = 9;
            txtPassWord.Text = "intech@2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 38);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 6;
            label6.Text = "Tên tài khoản";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 67);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 8;
            label8.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Location = new Point(137, 38);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Nhập vào tên tài khoản";
            txtUserName.Size = new Size(250, 22);
            txtUserName.TabIndex = 7;
            txtUserName.Text = "admin";
            // 
            // lbDateUpgrated
            // 
            lbDateUpgrated.AutoSize = true;
            lbDateUpgrated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDateUpgrated.Location = new Point(446, 128);
            lbDateUpgrated.Name = "lbDateUpgrated";
            lbDateUpgrated.Size = new Size(100, 21);
            lbDateUpgrated.TabIndex = 7;
            lbDateUpgrated.Text = "yyyy-mm-dd";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Silver;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point(676, 425);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 29);
            btnOk.TabIndex = 4;
            btnOk.Text = "Đăng nhập";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(319, 128);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 6;
            label7.Text = "Ngày cập nhật:";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbVersion.Location = new Point(249, 128);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(31, 21);
            lbVersion.TabIndex = 5;
            lbVersion.Text = "0.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(161, 128);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 4;
            label4.Text = "Phiên bản:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboLineType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLineName);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 138);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cài đặt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(744, 92);
            label5.Name = "label5";
            label5.Size = new Size(17, 21);
            label5.TabIndex = 5;
            label5.Text = "*";
            // 
            // cboLineType
            // 
            cboLineType.BackColor = Color.White;
            cboLineType.FlatStyle = FlatStyle.Flat;
            cboLineType.FormattingEnabled = true;
            cboLineType.Items.AddRange(new object[] { "DÂY CHUYỀN LẮP RÁP 1 - (24 công đoạn)", "DÂY CHUYỀN LẮP RÁP 2 - (17 công đoạn)" });
            cboLineType.Location = new Point(137, 84);
            cboLineType.Name = "cboLineType";
            cboLineType.Size = new Size(600, 29);
            cboLineType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 92);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Loại chuyền";
            // 
            // txtLineName
            // 
            txtLineName.BackColor = Color.White;
            txtLineName.BorderStyle = BorderStyle.None;
            txtLineName.Location = new Point(137, 43);
            txtLineName.Name = "txtLineName";
            txtLineName.Size = new Size(600, 35);
            txtLineName.TabIndex = 1;
            txtLineName.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 43);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên chuyền";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.HoaPhat_logo;
            pictureBox2.Location = new Point(275, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 78);
            label1.Name = "label1";
            label1.Size = new Size(479, 50);
            label1.TabIndex = 0;
            label1.Text = "Phần mềm Quản lý sản xuất";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(393, 39);
            label9.Name = "label9";
            label9.Size = new Size(122, 21);
            label9.TabIndex = 10;
            label9.Text = "Người vận hành";
            // 
            // txtOperatorName
            // 
            txtOperatorName.BorderStyle = BorderStyle.None;
            txtOperatorName.Location = new Point(393, 67);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.PlaceholderText = "Nhập vào tên người vận hành trạm đọc cân, serial";
            txtOperatorName.Size = new Size(377, 22);
            txtOperatorName.TabIndex = 11;
            // 
            // VersionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VersionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý sản xuất Hòa Phát";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cboLineType;
        private Label label3;
        private RichTextBox txtLineName;
        private Label label4;
        private Label lbDateUpgrated;
        private Label label7;
        private Label lbVersion;
        private Button btnOk;
        private Label label5;
        private TextBox txtPassWord;
        private Label label8;
        private TextBox txtUserName;
        private Label label6;
        private Button button1;
        private GroupBox groupBox2;
        private Panel panel7;
        private Label label9;
        private TextBox txtOperatorName;
    }
}