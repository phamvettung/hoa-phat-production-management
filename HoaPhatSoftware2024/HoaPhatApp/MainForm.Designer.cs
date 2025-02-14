using HoaPhatApp.UserControls;

namespace HoaPhatApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip1 = new StatusStrip();
            lbReady = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbServerStatus = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lbPortName = new ToolStripStatusLabel();
            pnLeft = new Panel();
            panel2 = new Panel();
            lbLoadCellStatus = new Label();
            label6 = new Label();
            cpnLoadCellStatus = new CircularPanel();
            picLogo = new PictureBox();
            panel3 = new Panel();
            lbCameraStatus = new Label();
            label3 = new Label();
            cpnCameraStatus = new CircularPanel();
            btnHome = new Button();
            btnHistory = new Button();
            panel1 = new Panel();
            lbPlcStatus = new Label();
            label1 = new Label();
            cpnPlcStatus = new CircularPanel();
            btnUser = new Button();
            btnReport = new Button();
            btnSetting = new Button();
            pnMainBody = new Panel();
            pnBody = new Panel();
            listBox1 = new ListBox();
            pnTittle = new Panel();
            panel4 = new Panel();
            lbRole = new Label();
            lbUserName = new Label();
            label4 = new Label();
            lbDate = new Label();
            lbTime = new Label();
            btnExtension = new Button();
            lbLineName = new Label();
            lbTittle = new Label();
            statusStrip1.SuspendLayout();
            pnLeft.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnMainBody.SuspendLayout();
            pnBody.SuspendLayout();
            pnTittle.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(231, 233, 241);
            statusStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbReady, toolStripStatusLabel1, lbServerStatus, toolStripStatusLabel2, lbPortName });
            statusStrip1.Location = new Point(60, 739);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(948, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbReady
            // 
            lbReady.Name = "lbReady";
            lbReady.Size = new Size(53, 21);
            lbReady.Text = "Ready";
            lbReady.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(807, 21);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "Server";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
            toolStripStatusLabel1.Visible = false;
            // 
            // lbServerStatus
            // 
            lbServerStatus.Name = "lbServerStatus";
            lbServerStatus.Size = new Size(69, 21);
            lbServerStatus.Text = "In Active";
            lbServerStatus.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(38, 21);
            toolStripStatusLabel2.Text = "Port";
            toolStripStatusLabel2.Visible = false;
            // 
            // lbPortName
            // 
            lbPortName.Name = "lbPortName";
            lbPortName.Size = new Size(19, 21);
            lbPortName.Text = "0";
            lbPortName.Visible = false;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(4, 64, 134);
            pnLeft.BackgroundImageLayout = ImageLayout.None;
            pnLeft.Controls.Add(panel2);
            pnLeft.Controls.Add(picLogo);
            pnLeft.Controls.Add(panel3);
            pnLeft.Controls.Add(btnHome);
            pnLeft.Controls.Add(btnHistory);
            pnLeft.Controls.Add(panel1);
            pnLeft.Controls.Add(btnUser);
            pnLeft.Controls.Add(btnReport);
            pnLeft.Controls.Add(btnSetting);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.ForeColor = Color.Black;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(60, 761);
            pnLeft.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbLoadCellStatus);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cpnLoadCellStatus);
            panel2.Location = new Point(-1, 712);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 48);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // lbLoadCellStatus
            // 
            lbLoadCellStatus.AutoSize = true;
            lbLoadCellStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLoadCellStatus.ForeColor = Color.White;
            lbLoadCellStatus.Location = new Point(110, 15);
            lbLoadCellStatus.Name = "lbLoadCellStatus";
            lbLoadCellStatus.Size = new Size(97, 21);
            lbLoadCellStatus.TabIndex = 5;
            lbLoadCellStatus.Text = "Chưa kết nối";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(64, 15);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 4;
            label6.Text = "Cân:";
            // 
            // cpnLoadCellStatus
            // 
            cpnLoadCellStatus.BackColor = SystemColors.ControlLight;
            cpnLoadCellStatus.Location = new Point(14, 9);
            cpnLoadCellStatus.Name = "cpnLoadCellStatus";
            cpnLoadCellStatus.Size = new Size(32, 32);
            cpnLoadCellStatus.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.HoaPhat_logo;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(230, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lbCameraStatus);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cpnCameraStatus);
            panel3.Location = new Point(-1, 658);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 48);
            panel3.TabIndex = 11;
            panel3.Visible = false;
            // 
            // lbCameraStatus
            // 
            lbCameraStatus.AutoSize = true;
            lbCameraStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCameraStatus.ForeColor = Color.White;
            lbCameraStatus.Location = new Point(130, 15);
            lbCameraStatus.Name = "lbCameraStatus";
            lbCameraStatus.Size = new Size(97, 21);
            lbCameraStatus.TabIndex = 3;
            lbCameraStatus.Text = "Chưa kết nối";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 15);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 2;
            label3.Text = "Camera:";
            // 
            // cpnCameraStatus
            // 
            cpnCameraStatus.BackColor = SystemColors.ControlLight;
            cpnCameraStatus.Location = new Point(14, 9);
            cpnCameraStatus.Name = "cpnCameraStatus";
            cpnCameraStatus.Size = new Size(32, 32);
            cpnCameraStatus.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 152, 210);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 152, 210);
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 152, 210);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 152, 210);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.dashboard_40;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 333);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(230, 48);
            btnHome.TabIndex = 1;
            btnHome.Text = "Trang chủ";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderColor = Color.FromArgb(0, 152, 210);
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 152, 210);
            btnHistory.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 152, 210);
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 152, 210);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = Properties.Resources.database_40;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 387);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(230, 48);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "Cơ sở dữ liệu";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lbPlcStatus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cpnPlcStatus);
            panel1.Location = new Point(-1, 604);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 48);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // lbPlcStatus
            // 
            lbPlcStatus.AutoSize = true;
            lbPlcStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPlcStatus.ForeColor = Color.White;
            lbPlcStatus.Location = new Point(109, 16);
            lbPlcStatus.Name = "lbPlcStatus";
            lbPlcStatus.Size = new Size(97, 21);
            lbPlcStatus.TabIndex = 2;
            lbPlcStatus.Text = "Chưa kết nối";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 16);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 1;
            label1.Text = "PLC:";
            // 
            // cpnPlcStatus
            // 
            cpnPlcStatus.BackColor = SystemColors.ControlLight;
            cpnPlcStatus.Location = new Point(14, 10);
            cpnPlcStatus.Name = "cpnPlcStatus";
            cpnPlcStatus.Size = new Size(32, 32);
            cpnPlcStatus.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 152, 210);
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 152, 210);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Image = Properties.Resources.user_40;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 549);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(230, 48);
            btnUser.TabIndex = 9;
            btnUser.Text = "Tài khoản";
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderColor = Color.FromArgb(0, 152, 210);
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 152, 210);
            btnReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 152, 210);
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 152, 210);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Image = Properties.Resources.report_40;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 441);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(230, 48);
            btnReport.TabIndex = 3;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.Transparent;
            btnSetting.FlatAppearance.BorderColor = Color.FromArgb(0, 152, 210);
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 152, 210);
            btnSetting.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 152, 210);
            btnSetting.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 152, 210);
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = Color.White;
            btnSetting.Image = Properties.Resources.setting_40;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 495);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(230, 48);
            btnSetting.TabIndex = 5;
            btnSetting.Text = "Thiết lập";
            btnSetting.UseVisualStyleBackColor = false;
            // 
            // pnMainBody
            // 
            pnMainBody.BackColor = SystemColors.Control;
            pnMainBody.Controls.Add(pnBody);
            pnMainBody.Controls.Add(pnTittle);
            pnMainBody.Dock = DockStyle.Fill;
            pnMainBody.Location = new Point(60, 0);
            pnMainBody.Name = "pnMainBody";
            pnMainBody.Size = new Size(948, 739);
            pnMainBody.TabIndex = 8;
            // 
            // pnBody
            // 
            pnBody.Controls.Add(listBox1);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 80);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(948, 659);
            pnBody.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.Dock = DockStyle.Fill;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(948, 659);
            listBox1.TabIndex = 0;
            // 
            // pnTittle
            // 
            pnTittle.BackColor = Color.White;
            pnTittle.Controls.Add(panel4);
            pnTittle.Controls.Add(lbRole);
            pnTittle.Controls.Add(lbUserName);
            pnTittle.Controls.Add(label4);
            pnTittle.Controls.Add(lbDate);
            pnTittle.Controls.Add(lbTime);
            pnTittle.Controls.Add(btnExtension);
            pnTittle.Controls.Add(lbLineName);
            pnTittle.Controls.Add(lbTittle);
            pnTittle.Dock = DockStyle.Top;
            pnTittle.Location = new Point(0, 0);
            pnTittle.Name = "pnTittle";
            pnTittle.Size = new Size(948, 80);
            pnTittle.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(65, 113, 167);
            panel4.Location = new Point(60, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(876, 3);
            panel4.TabIndex = 1;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.BackColor = Color.FromArgb(231, 233, 241);
            lbRole.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbRole.Location = new Point(162, 14);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(83, 30);
            lbRole.TabIndex = 10;
            lbRole.Text = "(admin)";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.FromArgb(231, 233, 241);
            lbUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbUserName.Location = new Point(60, 44);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(75, 30);
            lbUserName.TabIndex = 9;
            lbUserName.Text = "admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(231, 233, 241);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(60, 19);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 8;
            label4.Text = "Tài khoản - ";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbDate.AutoSize = true;
            lbDate.BackColor = Color.FromArgb(231, 233, 241);
            lbDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(827, 44);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(117, 30);
            lbDate.TabIndex = 6;
            lbDate.Text = "00/00/0000";
            // 
            // lbTime
            // 
            lbTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTime.AutoSize = true;
            lbTime.BackColor = Color.FromArgb(231, 233, 241);
            lbTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTime.Location = new Point(827, 14);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(89, 30);
            lbTime.TabIndex = 5;
            lbTime.Text = "00:00:00";
            // 
            // btnExtension
            // 
            btnExtension.BackColor = Color.FromArgb(231, 233, 241);
            btnExtension.FlatAppearance.BorderSize = 0;
            btnExtension.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnExtension.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            btnExtension.FlatStyle = FlatStyle.Flat;
            btnExtension.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExtension.ForeColor = Color.FromArgb(0, 192, 192);
            btnExtension.Location = new Point(0, -1);
            btnExtension.Name = "btnExtension";
            btnExtension.Size = new Size(54, 60);
            btnExtension.TabIndex = 1;
            btnExtension.Text = ">";
            btnExtension.UseVisualStyleBackColor = false;
            // 
            // lbLineName
            // 
            lbLineName.BackColor = Color.FromArgb(231, 233, 241);
            lbLineName.Dock = DockStyle.Fill;
            lbLineName.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbLineName.ForeColor = Color.DimGray;
            lbLineName.Location = new Point(0, 0);
            lbLineName.Name = "lbLineName";
            lbLineName.Size = new Size(948, 80);
            lbLineName.TabIndex = 7;
            lbLineName.Text = "Tên chuyền";
            lbLineName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTittle
            // 
            lbTittle.AutoSize = true;
            lbTittle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTittle.ForeColor = Color.FromArgb(64, 64, 64);
            lbTittle.Location = new Point(60, 18);
            lbTittle.Name = "lbTittle";
            lbTittle.Size = new Size(121, 32);
            lbTittle.TabIndex = 0;
            lbTittle.Text = "Overview";
            lbTittle.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 761);
            Controls.Add(pnMainBody);
            Controls.Add(statusStrip1);
            Controls.Add(pnLeft);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Phần mềm Quản lý sản xuất Hòa Phát";
            WindowState = FormWindowState.Maximized;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnMainBody.ResumeLayout(false);
            pnBody.ResumeLayout(false);
            pnTittle.ResumeLayout(false);
            pnTittle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private PictureBox picLogo;
        private Panel pnMainBody;
        private Button btnReport;
        private Button btnHistory;
        private Button btnHome;
        private Button btnSetting;
        private Panel pnTittle;
        private Panel pnBody;
        private Label lbTittle;
        private Button btnExtension;
        private ToolStripStatusLabel lbReady;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lbServerStatus;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lbPortName;
        private ListBox listBox1;
        private Label lbTime;
        private Label lbDate;
        private Label lbLineName;
        private Button btnUser;
        private Panel pnLeft;
        private Panel panel3;
        private Label lbCameraStatus;
        private Label label3;
        private CircularPanel cpnCameraStatus;
        private Panel panel2;
        private Label lbLoadCellStatus;
        private Label label6;
        private CircularPanel cpnLoadCellStatus;
        private Panel panel1;
        private Label lbPlcStatus;
        private Label label1;
        private CircularPanel cpnPlcStatus;
        private Label lbRole;
        private Label lbUserName;
        private Label label4;
        private Panel panel4;
    }
}
