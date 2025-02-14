namespace HoaPhatApp
{
    partial class ProductionOrderForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionOrderForm));
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel6 = new Panel();
            dgvModel = new Zuby.ADGV.AdvancedDataGridView();
            numOrderModel = new DataGridViewTextBoxColumn();
            modelCodeModel = new DataGridViewTextBoxColumn();
            modelNameModel = new DataGridViewTextBoxColumn();
            grossWeight = new DataGridViewTextBoxColumn();
            toLerance = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            btnAddToList = new Button();
            numQuantity = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            txtModelCode = new TextBox();
            label2 = new Label();
            txtModelName = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            dgvOperator = new Zuby.ADGV.AdvancedDataGridView();
            numOrderOpera = new DataGridViewTextBoxColumn();
            modelCodeOpera = new DataGridViewTextBoxColumn();
            numOperatorOpera = new DataGridViewTextBoxColumn();
            operatorNameOpera = new DataGridViewTextBoxColumn();
            excutionTime = new DataGridViewTextBoxColumn();
            isIgnore = new DataGridViewCheckBoxColumn();
            panel12 = new Panel();
            lbWarning = new Label();
            btnUpdate = new Button();
            panel8 = new Panel();
            label6 = new Label();
            panel9 = new Panel();
            dgvProductionOrder = new Zuby.ADGV.AdvancedDataGridView();
            dateOrder = new DataGridViewTextBoxColumn();
            modelCodeOrder = new DataGridViewTextBoxColumn();
            expectedOutput = new DataGridViewTextBoxColumn();
            action = new DataGridViewButtonColumn();
            panel11 = new Panel();
            btnStartProduction = new Button();
            btnCancel = new Button();
            panel10 = new Panel();
            label7 = new Label();
            statusStrip1 = new StatusStrip();
            lbMessage = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOperator).BeginInit();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductionOrder).BeginInit();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.background_menu;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 64);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1118, 8);
            label8.Name = "label8";
            label8.Size = new Size(214, 45);
            label8.TabIndex = 3;
            label8.Text = "Lệnh sản xuất";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 5);
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
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 743);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvModel);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 42);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 551);
            panel6.TabIndex = 2;
            // 
            // dgvModel
            // 
            dgvModel.AllowUserToAddRows = false;
            dgvModel.BackgroundColor = Color.White;
            dgvModel.BorderStyle = BorderStyle.Fixed3D;
            dgvModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModel.Columns.AddRange(new DataGridViewColumn[] { numOrderModel, modelCodeModel, modelNameModel, grossWeight, toLerance });
            dgvModel.Dock = DockStyle.Fill;
            dgvModel.FilterAndSortEnabled = true;
            dgvModel.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvModel.Location = new Point(0, 0);
            dgvModel.MaxFilterButtonImageHeight = 23;
            dgvModel.Name = "dgvModel";
            dgvModel.RightToLeft = RightToLeft.No;
            dgvModel.RowTemplate.Height = 25;
            dgvModel.Size = new Size(400, 551);
            dgvModel.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvModel.TabIndex = 2;
            // 
            // numOrderModel
            // 
            numOrderModel.DataPropertyName = "numOrder";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOrderModel.DefaultCellStyle = dataGridViewCellStyle1;
            numOrderModel.HeaderText = "STT";
            numOrderModel.MinimumWidth = 24;
            numOrderModel.Name = "numOrderModel";
            numOrderModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOrderModel.Width = 50;
            // 
            // modelCodeModel
            // 
            modelCodeModel.DataPropertyName = "modelCode";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCodeModel.DefaultCellStyle = dataGridViewCellStyle2;
            modelCodeModel.HeaderText = "Mã Model";
            modelCodeModel.MinimumWidth = 24;
            modelCodeModel.Name = "modelCodeModel";
            modelCodeModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeModel.Width = 150;
            // 
            // modelNameModel
            // 
            modelNameModel.DataPropertyName = "modelName";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelNameModel.DefaultCellStyle = dataGridViewCellStyle3;
            modelNameModel.HeaderText = "Tên Model";
            modelNameModel.MinimumWidth = 24;
            modelNameModel.Name = "modelNameModel";
            modelNameModel.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelNameModel.Width = 150;
            // 
            // grossWeight
            // 
            grossWeight.DataPropertyName = "grossWeight";
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grossWeight.DefaultCellStyle = dataGridViewCellStyle4;
            grossWeight.HeaderText = "Khối lượng cài đặt (kg)";
            grossWeight.MinimumWidth = 24;
            grossWeight.Name = "grossWeight";
            grossWeight.SortMode = DataGridViewColumnSortMode.Programmatic;
            grossWeight.Visible = false;
            grossWeight.Width = 150;
            // 
            // toLerance
            // 
            toLerance.DataPropertyName = "toLerance";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toLerance.DefaultCellStyle = dataGridViewCellStyle5;
            toLerance.HeaderText = "Sai số cho phép (%)";
            toLerance.MinimumWidth = 24;
            toLerance.Name = "toLerance";
            toLerance.SortMode = DataGridViewColumnSortMode.Programmatic;
            toLerance.Visible = false;
            toLerance.Width = 120;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAddToList);
            panel5.Controls.Add(numQuantity);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtModelCode);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtModelName);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 593);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 150);
            panel5.TabIndex = 1;
            // 
            // btnAddToList
            // 
            btnAddToList.BackColor = Color.LightSkyBlue;
            btnAddToList.FlatAppearance.BorderSize = 0;
            btnAddToList.FlatStyle = FlatStyle.Flat;
            btnAddToList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddToList.ForeColor = Color.White;
            btnAddToList.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddToList.Location = new Point(285, 100);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(100, 40);
            btnAddToList.TabIndex = 10;
            btnAddToList.Text = "Thêm";
            btnAddToList.UseVisualStyleBackColor = false;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            numQuantity.Location = new Point(112, 105);
            numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 35);
            numQuantity.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 119);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 6;
            label5.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(238, 119);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // txtModelCode
            // 
            txtModelCode.BackColor = SystemColors.Control;
            txtModelCode.BorderStyle = BorderStyle.None;
            txtModelCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelCode.Location = new Point(112, 48);
            txtModelCode.Name = "txtModelCode";
            txtModelCode.ReadOnly = true;
            txtModelCode.Size = new Size(250, 22);
            txtModelCode.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(11, 49);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 2;
            label2.Text = "Mã model";
            // 
            // txtModelName
            // 
            txtModelName.BackColor = SystemColors.Control;
            txtModelName.BorderStyle = BorderStyle.None;
            txtModelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelName.Location = new Point(112, 13);
            txtModelName.Name = "txtModelName";
            txtModelName.ReadOnly = true;
            txtModelName.Size = new Size(250, 22);
            txtModelName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên model";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 42);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(112, 6);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 0;
            label4.Text = "Danh sách Model";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dgvOperator);
            panel7.Controls.Add(panel12);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(418, 70);
            panel7.Name = "panel7";
            panel7.Size = new Size(455, 743);
            panel7.TabIndex = 2;
            // 
            // dgvOperator
            // 
            dgvOperator.AllowUserToAddRows = false;
            dgvOperator.BackgroundColor = Color.White;
            dgvOperator.BorderStyle = BorderStyle.Fixed3D;
            dgvOperator.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOperator.Columns.AddRange(new DataGridViewColumn[] { numOrderOpera, modelCodeOpera, numOperatorOpera, operatorNameOpera, excutionTime, isIgnore });
            dgvOperator.Dock = DockStyle.Fill;
            dgvOperator.FilterAndSortEnabled = true;
            dgvOperator.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperator.Location = new Point(0, 42);
            dgvOperator.MaxFilterButtonImageHeight = 23;
            dgvOperator.Name = "dgvOperator";
            dgvOperator.RightToLeft = RightToLeft.No;
            dgvOperator.RowTemplate.Height = 25;
            dgvOperator.Size = new Size(455, 641);
            dgvOperator.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvOperator.TabIndex = 4;
            // 
            // numOrderOpera
            // 
            numOrderOpera.DataPropertyName = "numOrder";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numOrderOpera.DefaultCellStyle = dataGridViewCellStyle6;
            numOrderOpera.HeaderText = "STT";
            numOrderOpera.MinimumWidth = 24;
            numOrderOpera.Name = "numOrderOpera";
            numOrderOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOrderOpera.Visible = false;
            numOrderOpera.Width = 80;
            // 
            // modelCodeOpera
            // 
            modelCodeOpera.DataPropertyName = "modelCode";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCodeOpera.DefaultCellStyle = dataGridViewCellStyle7;
            modelCodeOpera.HeaderText = "Model";
            modelCodeOpera.MinimumWidth = 24;
            modelCodeOpera.Name = "modelCodeOpera";
            modelCodeOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeOpera.Visible = false;
            modelCodeOpera.Width = 190;
            // 
            // numOperatorOpera
            // 
            numOperatorOpera.DataPropertyName = "numOperator";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            numOperatorOpera.DefaultCellStyle = dataGridViewCellStyle8;
            numOperatorOpera.HeaderText = "Số công đoạn";
            numOperatorOpera.MinimumWidth = 24;
            numOperatorOpera.Name = "numOperatorOpera";
            numOperatorOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            numOperatorOpera.Width = 80;
            // 
            // operatorNameOpera
            // 
            operatorNameOpera.DataPropertyName = "operatorName";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            operatorNameOpera.DefaultCellStyle = dataGridViewCellStyle9;
            operatorNameOpera.HeaderText = "Tên công đoạn";
            operatorNameOpera.MinimumWidth = 24;
            operatorNameOpera.Name = "operatorNameOpera";
            operatorNameOpera.SortMode = DataGridViewColumnSortMode.Programmatic;
            operatorNameOpera.Width = 150;
            // 
            // excutionTime
            // 
            excutionTime.DataPropertyName = "excutionTime";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.Format = "T";
            dataGridViewCellStyle10.NullValue = null;
            excutionTime.DefaultCellStyle = dataGridViewCellStyle10;
            excutionTime.HeaderText = "Thời gian thực hiện";
            excutionTime.MinimumWidth = 24;
            excutionTime.Name = "excutionTime";
            excutionTime.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isIgnore
            // 
            isIgnore.DataPropertyName = "isIgnore";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.NullValue = false;
            isIgnore.DefaultCellStyle = dataGridViewCellStyle11;
            isIgnore.HeaderText = "Bỏ qua";
            isIgnore.MinimumWidth = 24;
            isIgnore.Name = "isIgnore";
            isIgnore.Resizable = DataGridViewTriState.True;
            isIgnore.SortMode = DataGridViewColumnSortMode.Programmatic;
            isIgnore.Width = 80;
            // 
            // panel12
            // 
            panel12.Controls.Add(lbWarning);
            panel12.Controls.Add(btnUpdate);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 683);
            panel12.Name = "panel12";
            panel12.Size = new Size(455, 60);
            panel12.TabIndex = 4;
            // 
            // lbWarning
            // 
            lbWarning.AutoSize = true;
            lbWarning.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbWarning.ForeColor = Color.Red;
            lbWarning.Location = new Point(12, 29);
            lbWarning.Name = "lbWarning";
            lbWarning.Size = new Size(289, 21);
            lbWarning.TabIndex = 12;
            lbWarning.Text = "* Chú ý: Kiểm tra lại thông tin cài đặt";
            lbWarning.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSkyBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(341, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(455, 42);
            panel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(118, 6);
            label6.Name = "label6";
            label6.Size = new Size(219, 30);
            label6.TabIndex = 1;
            label6.Text = "Danh sách Công đoạn";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(dgvProductionOrder);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(879, 70);
            panel9.Name = "panel9";
            panel9.Size = new Size(453, 743);
            panel9.TabIndex = 3;
            // 
            // dgvProductionOrder
            // 
            dgvProductionOrder.BackgroundColor = Color.White;
            dgvProductionOrder.BorderStyle = BorderStyle.Fixed3D;
            dgvProductionOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductionOrder.Columns.AddRange(new DataGridViewColumn[] { dateOrder, modelCodeOrder, expectedOutput, action });
            dgvProductionOrder.Dock = DockStyle.Fill;
            dgvProductionOrder.FilterAndSortEnabled = true;
            dgvProductionOrder.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvProductionOrder.Location = new Point(0, 42);
            dgvProductionOrder.MaxFilterButtonImageHeight = 23;
            dgvProductionOrder.Name = "dgvProductionOrder";
            dgvProductionOrder.RightToLeft = RightToLeft.No;
            dgvProductionOrder.RowTemplate.Height = 25;
            dgvProductionOrder.Size = new Size(453, 641);
            dgvProductionOrder.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvProductionOrder.TabIndex = 5;
            // 
            // dateOrder
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.Format = "g";
            dataGridViewCellStyle12.NullValue = null;
            dateOrder.DefaultCellStyle = dataGridViewCellStyle12;
            dateOrder.HeaderText = "Ngày";
            dateOrder.MinimumWidth = 24;
            dateOrder.Name = "dateOrder";
            dateOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // modelCodeOrder
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            modelCodeOrder.DefaultCellStyle = dataGridViewCellStyle13;
            modelCodeOrder.HeaderText = "Model";
            modelCodeOrder.MinimumWidth = 24;
            modelCodeOrder.Name = "modelCodeOrder";
            modelCodeOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeOrder.Width = 150;
            // 
            // expectedOutput
            // 
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            expectedOutput.DefaultCellStyle = dataGridViewCellStyle14;
            expectedOutput.HeaderText = "Kế hoạch";
            expectedOutput.MinimumWidth = 24;
            expectedOutput.Name = "expectedOutput";
            expectedOutput.SortMode = DataGridViewColumnSortMode.Programmatic;
            expectedOutput.Width = 80;
            // 
            // action
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            action.DefaultCellStyle = dataGridViewCellStyle15;
            action.HeaderText = "Tác vụ";
            action.MinimumWidth = 24;
            action.Name = "action";
            action.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnStartProduction);
            panel11.Controls.Add(btnCancel);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 683);
            panel11.Name = "panel11";
            panel11.Size = new Size(453, 60);
            panel11.TabIndex = 3;
            // 
            // btnStartProduction
            // 
            btnStartProduction.BackColor = Color.LightSkyBlue;
            btnStartProduction.FlatAppearance.BorderSize = 0;
            btnStartProduction.FlatStyle = FlatStyle.Flat;
            btnStartProduction.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartProduction.ForeColor = Color.White;
            btnStartProduction.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartProduction.Location = new Point(201, 10);
            btnStartProduction.Name = "btnStartProduction";
            btnStartProduction.Size = new Size(238, 40);
            btnStartProduction.TabIndex = 12;
            btnStartProduction.Text = "Bắt đầu sản xuất";
            btnStartProduction.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(95, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(453, 42);
            panel10.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(155, 6);
            label7.Name = "label7";
            label7.Size = new Size(142, 30);
            label7.TabIndex = 2;
            label7.Text = "Lệnh sản xuất";
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbMessage });
            statusStrip1.Location = new Point(0, 819);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1344, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbMessage
            // 
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(0, 17);
            // 
            // ProductionOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 841);
            Controls.Add(statusStrip1);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProductionOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm Quản lý sản xuất Hòa Phát";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvModel).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOperator).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductionOrder).EndInit();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Zuby.ADGV.AdvancedDataGridView dgvModel;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel10;
        private Zuby.ADGV.AdvancedDataGridView dgvOperator;
        private DataGridViewTextBoxColumn numOrderOpera;
        private DataGridViewTextBoxColumn modelCodeOpera;
        private DataGridViewTextBoxColumn numOperatorOpera;
        private DataGridViewTextBoxColumn operatorNameOpera;
        private DataGridViewTextBoxColumn excutionTime;
        private DataGridViewCheckBoxColumn isIgnore;
        private DataGridViewTextBoxColumn numOrderModel;
        private DataGridViewTextBoxColumn modelCodeModel;
        private DataGridViewTextBoxColumn modelNameModel;
        private DataGridViewTextBoxColumn grossWeight;
        private DataGridViewTextBoxColumn toLerance;
        private Zuby.ADGV.AdvancedDataGridView dgvProductionOrder;
        private Panel panel12;
        private Label label3;
        private TextBox txtModelCode;
        private Label label2;
        private TextBox txtModelName;
        private Label label1;
        private NumericUpDown numQuantity;
        private Label label5;
        private Button btnAddToList;
        private Button btnStartProduction;
        private Button btnCancel;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn dateOrder;
        private DataGridViewTextBoxColumn modelCodeOrder;
        private DataGridViewTextBoxColumn expectedOutput;
        private DataGridViewButtonColumn action;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbMessage;
        private Label lbWarning;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}