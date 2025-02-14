namespace HoaPhatApp
{
    partial class ErrorForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnExport = new Button();
            label3 = new Label();
            dateEnd = new DateTimePicker();
            label2 = new Label();
            dateStart = new DateTimePicker();
            label1 = new Label();
            dgvError = new Zuby.ADGV.AdvancedDataGridView();
            bitError = new DataGridViewTextBoxColumn();
            errorName = new DataGridViewTextBoxColumn();
            solution = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            dgvErrorData = new Zuby.ADGV.AdvancedDataGridView();
            numOrder = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            ngay = new DataGridViewTextBoxColumn();
            bitErrorErrData = new DataGridViewTextBoxColumn();
            errorNameErrData = new DataGridViewTextBoxColumn();
            solutionErrData = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtSolution = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErrorData).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateEnd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateStart);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 98);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Điều kiện lọc";
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LimeGreen;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.ForeColor = Color.Transparent;
            btnExport.Image = Properties.Resources.excel35;
            btnExport.Location = new Point(734, 52);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(40, 40);
            btnExport.TabIndex = 12;
            btnExport.TextAlign = ContentAlignment.MiddleRight;
            btnExport.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 28);
            label3.Name = "label3";
            label3.Size = new Size(681, 21);
            label3.TabIndex = 4;
            label3.Text = "Chú thích: Tìm kiếm theo khoảng thời gian từ ngày bắt đầu đến ngày kết thúc trong Cơ sở dữ liệu";
            // 
            // dateEnd
            // 
            dateEnd.CalendarMonthBackground = SystemColors.Control;
            dateEnd.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(439, 61);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 29);
            dateEnd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(327, 69);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 2;
            label2.Text = "Ngày kết thúc";
            // 
            // dateStart
            // 
            dateStart.CalendarMonthBackground = SystemColors.Control;
            dateStart.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(119, 61);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 29);
            dateStart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 69);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Ngày bắt đầu";
            // 
            // dgvError
            // 
            dgvError.BackgroundColor = Color.White;
            dgvError.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvError.Columns.AddRange(new DataGridViewColumn[] { bitError, errorName, solution });
            dgvError.FilterAndSortEnabled = true;
            dgvError.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvError.Location = new Point(0, 0);
            dgvError.MaxFilterButtonImageHeight = 23;
            dgvError.Name = "dgvError";
            dgvError.RightToLeft = RightToLeft.No;
            dgvError.RowTemplate.Height = 25;
            dgvError.Size = new Size(780, 763);
            dgvError.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvError.TabIndex = 0;
            // 
            // bitError
            // 
            bitError.DataPropertyName = "bitError";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bitError.DefaultCellStyle = dataGridViewCellStyle1;
            bitError.HeaderText = "Bit";
            bitError.MinimumWidth = 24;
            bitError.Name = "bitError";
            bitError.SortMode = DataGridViewColumnSortMode.Programmatic;
            bitError.Width = 80;
            // 
            // errorName
            // 
            errorName.DataPropertyName = "errorName";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorName.DefaultCellStyle = dataGridViewCellStyle2;
            errorName.HeaderText = "Lỗi";
            errorName.MinimumWidth = 24;
            errorName.Name = "errorName";
            errorName.SortMode = DataGridViewColumnSortMode.Programmatic;
            errorName.Width = 200;
            // 
            // solution
            // 
            solution.DataPropertyName = "solution";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            solution.DefaultCellStyle = dataGridViewCellStyle3;
            solution.HeaderText = "Giải pháp";
            solution.MinimumWidth = 24;
            solution.Name = "solution";
            solution.SortMode = DataGridViewColumnSortMode.Programmatic;
            solution.Width = 800;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 116);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(dgvError);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(dgvErrorData);
            splitContainer1.Size = new Size(1840, 763);
            splitContainer1.SplitterDistance = 780;
            splitContainer1.TabIndex = 6;
            // 
            // dgvErrorData
            // 
            dgvErrorData.AllowUserToAddRows = false;
            dgvErrorData.BackgroundColor = Color.White;
            dgvErrorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrorData.Columns.AddRange(new DataGridViewColumn[] { numOrder, id, ngay, bitErrorErrData, errorNameErrData, solutionErrData });
            dgvErrorData.Dock = DockStyle.Fill;
            dgvErrorData.FilterAndSortEnabled = true;
            dgvErrorData.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvErrorData.Location = new Point(0, 0);
            dgvErrorData.MaxFilterButtonImageHeight = 23;
            dgvErrorData.Name = "dgvErrorData";
            dgvErrorData.RightToLeft = RightToLeft.No;
            dgvErrorData.RowTemplate.Height = 25;
            dgvErrorData.Size = new Size(1056, 763);
            dgvErrorData.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvErrorData.TabIndex = 0;
            // 
            // numOrder
            // 
            numOrder.DataPropertyName = "numOrder";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOrder.DefaultCellStyle = dataGridViewCellStyle4;
            numOrder.HeaderText = "STT";
            numOrder.MinimumWidth = 24;
            numOrder.Name = "numOrder";
            numOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.DefaultCellStyle = dataGridViewCellStyle5;
            id.HeaderText = "ID";
            id.MinimumWidth = 24;
            id.Name = "id";
            id.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ngay
            // 
            ngay.DataPropertyName = "ngay";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "G";
            dataGridViewCellStyle6.NullValue = null;
            ngay.DefaultCellStyle = dataGridViewCellStyle6;
            ngay.HeaderText = "Ngày";
            ngay.MinimumWidth = 24;
            ngay.Name = "ngay";
            ngay.SortMode = DataGridViewColumnSortMode.Programmatic;
            ngay.Width = 200;
            // 
            // bitErrorErrData
            // 
            bitErrorErrData.DataPropertyName = "bitError";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bitErrorErrData.DefaultCellStyle = dataGridViewCellStyle7;
            bitErrorErrData.HeaderText = "Bit";
            bitErrorErrData.MinimumWidth = 24;
            bitErrorErrData.Name = "bitErrorErrData";
            bitErrorErrData.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // errorNameErrData
            // 
            errorNameErrData.DataPropertyName = "errorName";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorNameErrData.DefaultCellStyle = dataGridViewCellStyle8;
            errorNameErrData.HeaderText = "Lỗi";
            errorNameErrData.MinimumWidth = 24;
            errorNameErrData.Name = "errorNameErrData";
            errorNameErrData.SortMode = DataGridViewColumnSortMode.Programmatic;
            errorNameErrData.Width = 600;
            // 
            // solutionErrData
            // 
            solutionErrData.DataPropertyName = "solution";
            solutionErrData.HeaderText = "Giải pháp";
            solutionErrData.MinimumWidth = 24;
            solutionErrData.Name = "solutionErrData";
            solutionErrData.SortMode = DataGridViewColumnSortMode.Programmatic;
            solutionErrData.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(txtSolution);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(798, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1054, 98);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hướng xử lý";
            // 
            // txtSolution
            // 
            txtSolution.BackColor = SystemColors.Control;
            txtSolution.Location = new Point(6, 28);
            txtSolution.Name = "txtSolution";
            txtSolution.Size = new Size(1042, 62);
            txtSolution.TabIndex = 0;
            txtSolution.Text = "";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1864, 891);
            Controls.Add(groupBox2);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Name = "ErrorForm";
            Text = "ErrorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvError).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvErrorData).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnExport;
        private Label label3;
        private Zuby.ADGV.AdvancedDataGridView dgvError;
        private SplitContainer splitContainer1;
        private Zuby.ADGV.AdvancedDataGridView dgvErrorData;
        private DataGridViewTextBoxColumn bitError;
        private DataGridViewTextBoxColumn errorName;
        private DataGridViewTextBoxColumn solution;
        private DateTimePicker dateEnd;
        private Label label2;
        private DateTimePicker dateStart;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox txtSolution;
        private DataGridViewTextBoxColumn numOrder;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ngay;
        private DataGridViewTextBoxColumn bitErrorErrData;
        private DataGridViewTextBoxColumn errorNameErrData;
        private DataGridViewTextBoxColumn solutionErrData;
    }
}