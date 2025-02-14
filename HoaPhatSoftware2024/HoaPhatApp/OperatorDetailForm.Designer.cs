namespace HoaPhatApp
{
    partial class OperatorDetailForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorDetailForm));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtStatus = new RichTextBox();
            txtEndTime = new TextBox();
            label6 = new Label();
            txtStartTime = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtExcutionTime = new TextBox();
            label4 = new Label();
            txtNumOperator = new TextBox();
            label3 = new Label();
            txtOperatorName = new TextBox();
            label2 = new Label();
            txtModelCode = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            dgvOperatorData = new Zuby.ADGV.AdvancedDataGridView();
            id = new DataGridViewTextBoxColumn();
            modelCode = new DataGridViewTextBoxColumn();
            numOperator = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            startTime = new DataGridViewTextBoxColumn();
            endTime = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperatorData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.background_menu;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 64);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 5);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtEndTime);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtStartTime);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtExcutionTime);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtNumOperator);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtOperatorName);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtModelCode);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel5);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(12, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 647);
            panel3.TabIndex = 2;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(224, 224, 224);
            txtStatus.Location = new Point(209, 270);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(170, 44);
            txtStatus.TabIndex = 15;
            txtStatus.Text = "";
            // 
            // txtEndTime
            // 
            txtEndTime.BackColor = Color.FromArgb(224, 224, 224);
            txtEndTime.BorderStyle = BorderStyle.None;
            txtEndTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndTime.Location = new Point(209, 361);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.ReadOnly = true;
            txtEndTime.Size = new Size(170, 28);
            txtEndTime.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(209, 333);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 13;
            label6.Text = "Thời gian kết thúc";
            // 
            // txtStartTime
            // 
            txtStartTime.BackColor = Color.FromArgb(224, 224, 224);
            txtStartTime.BorderStyle = BorderStyle.None;
            txtStartTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartTime.Location = new Point(20, 361);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.ReadOnly = true;
            txtStartTime.Size = new Size(170, 28);
            txtStartTime.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 333);
            label7.Name = "label7";
            label7.Size = new Size(160, 25);
            label7.TabIndex = 11;
            label7.Text = "Thời gian bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 270);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái hiện tại";
            // 
            // txtExcutionTime
            // 
            txtExcutionTime.BackColor = Color.FromArgb(224, 224, 224);
            txtExcutionTime.BorderStyle = BorderStyle.None;
            txtExcutionTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtExcutionTime.Location = new Point(209, 220);
            txtExcutionTime.Name = "txtExcutionTime";
            txtExcutionTime.ReadOnly = true;
            txtExcutionTime.Size = new Size(170, 28);
            txtExcutionTime.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(209, 192);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 7;
            label4.Text = "Thời gian cho phép";
            // 
            // txtNumOperator
            // 
            txtNumOperator.BackColor = Color.FromArgb(224, 224, 224);
            txtNumOperator.BorderStyle = BorderStyle.None;
            txtNumOperator.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumOperator.Location = new Point(20, 220);
            txtNumOperator.Name = "txtNumOperator";
            txtNumOperator.ReadOnly = true;
            txtNumOperator.Size = new Size(170, 28);
            txtNumOperator.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 192);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 5;
            label3.Text = "Số công đoạn";
            // 
            // txtOperatorName
            // 
            txtOperatorName.BackColor = Color.FromArgb(224, 224, 224);
            txtOperatorName.BorderStyle = BorderStyle.None;
            txtOperatorName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOperatorName.Location = new Point(22, 152);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.ReadOnly = true;
            txtOperatorName.Size = new Size(357, 28);
            txtOperatorName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 124);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên công đoạn";
            // 
            // txtModelCode
            // 
            txtModelCode.BackColor = Color.FromArgb(224, 224, 224);
            txtModelCode.BorderStyle = BorderStyle.None;
            txtModelCode.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelCode.Location = new Point(22, 89);
            txtModelCode.Name = "txtModelCode";
            txtModelCode.ReadOnly = true;
            txtModelCode.Size = new Size(357, 28);
            txtModelCode.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã model";
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 50);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dgvOperatorData);
            panel4.Controls.Add(panel6);
            panel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(418, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(578, 647);
            panel4.TabIndex = 3;
            // 
            // dgvOperatorData
            // 
            dgvOperatorData.AllowUserToAddRows = false;
            dgvOperatorData.BackgroundColor = Color.White;
            dgvOperatorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperatorData.Columns.AddRange(new DataGridViewColumn[] { id, modelCode, numOperator, date, startTime, endTime });
            dgvOperatorData.Dock = DockStyle.Fill;
            dgvOperatorData.FilterAndSortEnabled = true;
            dgvOperatorData.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperatorData.Location = new Point(0, 50);
            dgvOperatorData.MaxFilterButtonImageHeight = 23;
            dgvOperatorData.Name = "dgvOperatorData";
            dgvOperatorData.RightToLeft = RightToLeft.No;
            dgvOperatorData.RowTemplate.Height = 25;
            dgvOperatorData.Size = new Size(578, 597);
            dgvOperatorData.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperatorData.TabIndex = 2;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.MinimumWidth = 24;
            id.Name = "id";
            id.SortMode = DataGridViewColumnSortMode.Programmatic;
            id.Visible = false;
            // 
            // modelCode
            // 
            modelCode.DataPropertyName = "modelCode";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCode.DefaultCellStyle = dataGridViewCellStyle2;
            modelCode.HeaderText = "Model";
            modelCode.MinimumWidth = 24;
            modelCode.Name = "modelCode";
            modelCode.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // numOperator
            // 
            numOperator.DataPropertyName = "numOperator";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOperator.DefaultCellStyle = dataGridViewCellStyle3;
            numOperator.HeaderText = "Công đoạn";
            numOperator.MinimumWidth = 24;
            numOperator.Name = "numOperator";
            numOperator.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOperator.Width = 80;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            date.DefaultCellStyle = dataGridViewCellStyle4;
            date.HeaderText = "Ngày";
            date.MinimumWidth = 24;
            date.Name = "date";
            date.SortMode = DataGridViewColumnSortMode.Programmatic;
            date.Width = 150;
            // 
            // startTime
            // 
            startTime.DataPropertyName = "startTime";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            startTime.DefaultCellStyle = dataGridViewCellStyle5;
            startTime.HeaderText = "Thời gian bắt đầu";
            startTime.MinimumWidth = 24;
            startTime.Name = "startTime";
            startTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // endTime
            // 
            endTime.DataPropertyName = "endTime";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "T";
            dataGridViewCellStyle6.NullValue = null;
            endTime.DefaultCellStyle = dataGridViewCellStyle6;
            endTime.HeaderText = "Thời gian kết thúc";
            endTime.MinimumWidth = 24;
            endTime.Name = "endTime";
            endTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(578, 50);
            panel6.TabIndex = 1;
            // 
            // OperatorDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OperatorDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết công đoạn";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOperatorData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtOperatorName;
        private Label label2;
        private TextBox txtModelCode;
        private Label label1;
        private TextBox txtExcutionTime;
        private Label label4;
        private TextBox txtNumOperator;
        private Label label3;
        private Label label5;
        private TextBox txtEndTime;
        private Label label6;
        private TextBox txtStartTime;
        private Label label7;
        private Zuby.ADGV.AdvancedDataGridView dgvOperatorData;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn modelCode;
        private DataGridViewTextBoxColumn numOperator;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn startTime;
        private DataGridViewTextBoxColumn endTime;
        private RichTextBox txtStatus;
    }
}