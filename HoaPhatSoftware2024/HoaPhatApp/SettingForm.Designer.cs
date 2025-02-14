namespace HoaPhatApp
{
    partial class SettingForm
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
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            pnBody = new Panel();
            dgvModel = new Zuby.ADGV.AdvancedDataGridView();
            numOrderModel = new DataGridViewTextBoxColumn();
            modelCodeModel = new DataGridViewTextBoxColumn();
            modelNameModel = new DataGridViewTextBoxColumn();
            grossWeight = new DataGridViewTextBoxColumn();
            toLerance = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnOpen = new Button();
            btnExportModel = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btnUpdate = new Button();
            dgvOperator = new Zuby.ADGV.AdvancedDataGridView();
            numOrderOpera = new DataGridViewTextBoxColumn();
            modelCodeOpera = new DataGridViewTextBoxColumn();
            numOperatorOpera = new DataGridViewTextBoxColumn();
            operatorNameOpera = new DataGridViewTextBoxColumn();
            excutionTime = new DataGridViewTextBoxColumn();
            isIgnore = new DataGridViewCheckBoxColumn();
            panel4 = new Panel();
            btnExportOpera = new Button();
            btnWriteTimeToPLC = new Button();
            label2 = new Label();
            btnOk = new Button();
            dateEnd = new DateTimePicker();
            label4 = new Label();
            dateStart = new DateTimePicker();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnActiveCamera = new Button();
            groupBox3 = new GroupBox();
            cboBCR = new ComboBox();
            pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperator).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(dgvModel);
            pnBody.Controls.Add(panel3);
            pnBody.Location = new Point(12, 12);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(820, 867);
            pnBody.TabIndex = 0;
            // 
            // dgvModel
            // 
            dgvModel.AllowUserToAddRows = false;
            dgvModel.BackgroundColor = Color.White;
            dgvModel.BorderStyle = BorderStyle.Fixed3D;
            dgvModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModel.Columns.AddRange(new DataGridViewColumn[] { numOrderModel, modelCodeModel, modelNameModel, grossWeight, toLerance });
            dgvModel.FilterAndSortEnabled = true;
            dgvModel.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvModel.Location = new Point(13, 56);
            dgvModel.MaxFilterButtonImageHeight = 23;
            dgvModel.Name = "dgvModel";
            dgvModel.RightToLeft = RightToLeft.No;
            dgvModel.RowTemplate.Height = 25;
            dgvModel.Size = new Size(793, 794);
            dgvModel.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvModel.TabIndex = 1;
            // 
            // numOrderModel
            // 
            numOrderModel.DataPropertyName = "numOrder";
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOrderModel.DefaultCellStyle = dataGridViewCellStyle12;
            numOrderModel.HeaderText = "STT";
            numOrderModel.MinimumWidth = 24;
            numOrderModel.Name = "numOrderModel";
            numOrderModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOrderModel.Width = 80;
            // 
            // modelCodeModel
            // 
            modelCodeModel.DataPropertyName = "modelCode";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCodeModel.DefaultCellStyle = dataGridViewCellStyle13;
            modelCodeModel.HeaderText = "Mã Model";
            modelCodeModel.MinimumWidth = 24;
            modelCodeModel.Name = "modelCodeModel";
            modelCodeModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeModel.Width = 150;
            // 
            // modelNameModel
            // 
            modelNameModel.DataPropertyName = "modelName";
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelNameModel.DefaultCellStyle = dataGridViewCellStyle14;
            modelNameModel.HeaderText = "Tên Model";
            modelNameModel.MinimumWidth = 24;
            modelNameModel.Name = "modelNameModel";
            modelNameModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelNameModel.Width = 250;
            // 
            // grossWeight
            // 
            grossWeight.DataPropertyName = "grossWeight";
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grossWeight.DefaultCellStyle = dataGridViewCellStyle15;
            grossWeight.HeaderText = "Khối lượng cài đặt (kg)";
            grossWeight.MinimumWidth = 24;
            grossWeight.Name = "grossWeight";
            grossWeight.SortMode = DataGridViewColumnSortMode.Programmatic;
            grossWeight.Width = 150;
            // 
            // toLerance
            // 
            toLerance.DataPropertyName = "toLerance";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toLerance.DefaultCellStyle = dataGridViewCellStyle16;
            toLerance.HeaderText = "Sai số cho phép (g)";
            toLerance.MinimumWidth = 24;
            toLerance.Name = "toLerance";
            toLerance.SortMode = DataGridViewColumnSortMode.Programmatic;
            toLerance.Width = 120;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(btnOpen);
            panel3.Controls.Add(btnExportModel);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(820, 50);
            panel3.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.LawnGreen;
            btnOpen.FlatAppearance.BorderColor = Color.Gray;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Image = Properties.Resources.open_40;
            btnOpen.Location = new Point(766, 5);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(40, 40);
            btnOpen.TabIndex = 4;
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnExportModel
            // 
            btnExportModel.BackColor = Color.FromArgb(0, 192, 0);
            btnExportModel.FlatAppearance.BorderColor = Color.Gray;
            btnExportModel.FlatStyle = FlatStyle.Flat;
            btnExportModel.Image = Properties.Resources.excel35;
            btnExportModel.Location = new Point(719, 5);
            btnExportModel.Name = "btnExportModel";
            btnExportModel.Size = new Size(40, 40);
            btnExportModel.TabIndex = 3;
            btnExportModel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH SÁCH CÁC MODEL";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(dgvOperator);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(850, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 759);
            panel2.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSkyBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = Properties.Resources.update_40;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(864, 712);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            // 
            // dgvOperator
            // 
            dgvOperator.AllowUserToAddRows = false;
            dgvOperator.BackgroundColor = Color.White;
            dgvOperator.BorderStyle = BorderStyle.Fixed3D;
            dgvOperator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperator.Columns.AddRange(new DataGridViewColumn[] { numOrderOpera, modelCodeOpera, numOperatorOpera, operatorNameOpera, excutionTime, isIgnore });
            dgvOperator.FilterAndSortEnabled = true;
            dgvOperator.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperator.Location = new Point(13, 56);
            dgvOperator.MaxFilterButtonImageHeight = 23;
            dgvOperator.Name = "dgvOperator";
            dgvOperator.RightToLeft = RightToLeft.No;
            dgvOperator.RowTemplate.Height = 25;
            dgvOperator.Size = new Size(976, 650);
            dgvOperator.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperator.TabIndex = 2;
            // 
            // numOrderOpera
            // 
            numOrderOpera.DataPropertyName = "numOrder";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOrderOpera.DefaultCellStyle = dataGridViewCellStyle17;
            numOrderOpera.HeaderText = "STT";
            numOrderOpera.MinimumWidth = 24;
            numOrderOpera.Name = "numOrderOpera";
            numOrderOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOrderOpera.Width = 80;
            // 
            // modelCodeOpera
            // 
            modelCodeOpera.DataPropertyName = "modelCode";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCodeOpera.DefaultCellStyle = dataGridViewCellStyle18;
            modelCodeOpera.HeaderText = "Model";
            modelCodeOpera.MinimumWidth = 24;
            modelCodeOpera.Name = "modelCodeOpera";
            modelCodeOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeOpera.Width = 190;
            // 
            // numOperatorOpera
            // 
            numOperatorOpera.DataPropertyName = "numOperator";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = null;
            numOperatorOpera.DefaultCellStyle = dataGridViewCellStyle19;
            numOperatorOpera.HeaderText = "Số công đoạn";
            numOperatorOpera.MinimumWidth = 24;
            numOperatorOpera.Name = "numOperatorOpera";
            numOperatorOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOperatorOpera.Width = 150;
            // 
            // operatorNameOpera
            // 
            operatorNameOpera.DataPropertyName = "operatorName";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            operatorNameOpera.DefaultCellStyle = dataGridViewCellStyle20;
            operatorNameOpera.HeaderText = "Tên công đoạn";
            operatorNameOpera.MinimumWidth = 24;
            operatorNameOpera.Name = "operatorNameOpera";
            operatorNameOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            operatorNameOpera.Width = 250;
            // 
            // excutionTime
            // 
            excutionTime.DataPropertyName = "excutionTime";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.Format = "T";
            dataGridViewCellStyle21.NullValue = null;
            excutionTime.DefaultCellStyle = dataGridViewCellStyle21;
            excutionTime.HeaderText = "Thời gian thực hiện";
            excutionTime.MinimumWidth = 24;
            excutionTime.Name = "excutionTime";
            excutionTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            excutionTime.Width = 150;
            // 
            // isIgnore
            // 
            isIgnore.DataPropertyName = "isIgnore";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.NullValue = false;
            isIgnore.DefaultCellStyle = dataGridViewCellStyle22;
            isIgnore.HeaderText = "Bỏ qua";
            isIgnore.MinimumWidth = 24;
            isIgnore.Name = "isIgnore";
            isIgnore.Resizable = DataGridViewTriState.True;
            isIgnore.SortMode = DataGridViewColumnSortMode.Programmatic;
            isIgnore.Width = 110;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(btnExportOpera);
            panel4.Controls.Add(btnWriteTimeToPLC);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 50);
            panel4.TabIndex = 1;
            // 
            // btnExportOpera
            // 
            btnExportOpera.BackColor = Color.FromArgb(0, 192, 0);
            btnExportOpera.FlatAppearance.BorderColor = Color.Gray;
            btnExportOpera.FlatStyle = FlatStyle.Flat;
            btnExportOpera.Image = Properties.Resources.excel35;
            btnExportOpera.Location = new Point(903, 5);
            btnExportOpera.Name = "btnExportOpera";
            btnExportOpera.Size = new Size(40, 40);
            btnExportOpera.TabIndex = 2;
            btnExportOpera.UseVisualStyleBackColor = false;
            // 
            // btnWriteTimeToPLC
            // 
            btnWriteTimeToPLC.BackColor = Color.Gold;
            btnWriteTimeToPLC.FlatAppearance.BorderColor = Color.Gray;
            btnWriteTimeToPLC.FlatStyle = FlatStyle.Flat;
            btnWriteTimeToPLC.Image = Properties.Resources.write_40;
            btnWriteTimeToPLC.Location = new Point(949, 5);
            btnWriteTimeToPLC.Name = "btnWriteTimeToPLC";
            btnWriteTimeToPLC.Size = new Size(40, 40);
            btnWriteTimeToPLC.TabIndex = 1;
            btnWriteTimeToPLC.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(293, 25);
            label2.TabIndex = 0;
            label2.Text = "DANH SÁCH CÁC CÔNG ĐOẠN ";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Silver;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(361, 59);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(60, 35);
            btnOk.TabIndex = 14;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // dateEnd
            // 
            dateEnd.CalendarMonthBackground = SystemColors.Control;
            dateEnd.CustomFormat = "HH:mm:ss";
            dateEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(155, 65);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 29);
            dateEnd.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 71);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 12;
            label4.Text = "Thời gian kết thúc";
            // 
            // dateStart
            // 
            dateStart.CalendarMonthBackground = SystemColors.Control;
            dateStart.CustomFormat = "HH:mm:ss";
            dateStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateStart.Format = DateTimePickerFormat.Custom;
            dateStart.Location = new Point(155, 34);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 29);
            dateStart.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 40);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 10;
            label5.Text = "Thời gian bắt đầu";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(dateStart);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateEnd);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(850, 779);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cài đặt thời gian sản xuất";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnActiveCamera);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1287, 779);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Active/Inactive Camera";
            // 
            // btnActiveCamera
            // 
            btnActiveCamera.BackColor = Color.Lime;
            btnActiveCamera.FlatAppearance.BorderSize = 0;
            btnActiveCamera.FlatStyle = FlatStyle.Flat;
            btnActiveCamera.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActiveCamera.ForeColor = Color.Red;
            btnActiveCamera.ImageAlign = ContentAlignment.MiddleLeft;
            btnActiveCamera.Location = new Point(64, 59);
            btnActiveCamera.Name = "btnActiveCamera";
            btnActiveCamera.Size = new Size(133, 35);
            btnActiveCamera.TabIndex = 14;
            btnActiveCamera.Text = "Tắt camera";
            btnActiveCamera.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboBCR);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(1555, 779);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(262, 100);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "OTP/HIK";
            // 
            // cboBCR
            // 
            cboBCR.FormattingEnabled = true;
            cboBCR.Items.AddRange(new object[] { "HIK", "OTP" });
            cboBCR.Location = new Point(6, 56);
            cboBCR.Name = "cboBCR";
            cboBCR.Size = new Size(250, 38);
            cboBCR.TabIndex = 0;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 233, 241);
            ClientSize = new Size(1864, 891);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(pnBody);
            Name = "SettingForm";
            Text = "SettingForm";
            pnBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvModel).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOperator).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBody;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Zuby.ADGV.AdvancedDataGridView dgvModel;
        private Zuby.ADGV.AdvancedDataGridView dgvOperator;
        private DataGridViewTextBoxColumn numOrderOpera;
        private DataGridViewTextBoxColumn modelCodeOpera;
        private DataGridViewTextBoxColumn numOperatorOpera;
        private DataGridViewTextBoxColumn operatorNameOpera;
        private DataGridViewTextBoxColumn excutionTime;
        private DataGridViewCheckBoxColumn isIgnore;
        private Button btnWriteTimeToPLC;
        private Button btnOpen;
        private Button btnExportModel;
        private Button btnExportOpera;
        private Button btnUpdate;
        private DateTimePicker dateEnd;
        private Label label4;
        private DateTimePicker dateStart;
        private Label label5;
        private Button btnOk;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn numOrderModel;
        private DataGridViewTextBoxColumn modelCodeModel;
        private DataGridViewTextBoxColumn modelNameModel;
        private DataGridViewTextBoxColumn grossWeight;
        private DataGridViewTextBoxColumn toLerance;
        private GroupBox groupBox2;
        private Button btnActiveCamera;
        private GroupBox groupBox3;
        private ComboBox cboBCR;
    }
}