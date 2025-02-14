using System.ComponentModel;

namespace HoaPhatApp
{
    partial class HomeForm
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
            btnCreateNewOrder = new Button();
            btnNextModel = new Button();
            dgvProductionOrder = new Zuby.ADGV.AdvancedDataGridView();
            stt = new DataGridViewTextBoxColumn();
            idOrder = new DataGridViewTextBoxColumn();
            dateOrder = new DataGridViewTextBoxColumn();
            modelCodeOrder = new DataGridViewTextBoxColumn();
            expectedOutputOrder = new DataGridViewTextBoxColumn();
            actualOutputOrder = new DataGridViewTextBoxColumn();
            statusOrder = new DataGridViewTextBoxColumn();
            circularPanel1 = new UserControls.CircularPanel();
            cpnPlcStatus = new UserControls.CircularPanel();
            label5 = new Label();
            panel1 = new Panel();
            lbCurrentModel = new Label();
            label6 = new Label();
            txtCurrentModelOutput = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbMessageToSave = new Label();
            artanPanel1 = new UserControls.ArtanPanel();
            txtActualOutput = new TextBox();
            txtExpectOutput = new TextBox();
            artanGradientPanel1 = new UserControls.ArtanGradientPanel();
            panel2 = new Panel();
            ((ISupportInitialize)dgvProductionOrder).BeginInit();
            panel1.SuspendLayout();
            artanPanel1.SuspendLayout();
            artanGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateNewOrder
            // 
            btnCreateNewOrder.BackColor = Color.Transparent;
            btnCreateNewOrder.FlatAppearance.BorderSize = 0;
            btnCreateNewOrder.FlatStyle = FlatStyle.Flat;
            btnCreateNewOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateNewOrder.ForeColor = Color.White;
            btnCreateNewOrder.Image = Properties.Resources.list_40;
            btnCreateNewOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateNewOrder.Location = new Point(22, 274);
            btnCreateNewOrder.Name = "btnCreateNewOrder";
            btnCreateNewOrder.Size = new Size(312, 40);
            btnCreateNewOrder.TabIndex = 17;
            btnCreateNewOrder.Text = "Tạo Lệnh sản xuất";
            btnCreateNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnNextModel
            // 
            btnNextModel.BackColor = Color.Transparent;
            btnNextModel.FlatAppearance.BorderSize = 0;
            btnNextModel.FlatStyle = FlatStyle.Flat;
            btnNextModel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextModel.ForeColor = Color.White;
            btnNextModel.Image = Properties.Resources.next_32;
            btnNextModel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNextModel.Location = new Point(384, 274);
            btnNextModel.Name = "btnNextModel";
            btnNextModel.Size = new Size(188, 40);
            btnNextModel.TabIndex = 12;
            btnNextModel.Text = "Chuyển Model";
            btnNextModel.TextAlign = ContentAlignment.MiddleRight;
            btnNextModel.UseVisualStyleBackColor = false;
            // 
            // dgvProductionOrder
            // 
            dgvProductionOrder.AllowUserToAddRows = false;
            dgvProductionOrder.BackgroundColor = Color.White;
            dgvProductionOrder.BorderStyle = BorderStyle.None;
            dgvProductionOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductionOrder.Columns.AddRange(new DataGridViewColumn[] { stt, idOrder, dateOrder, modelCodeOrder, expectedOutputOrder, actualOutputOrder, statusOrder });
            dgvProductionOrder.FilterAndSortEnabled = true;
            dgvProductionOrder.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvProductionOrder.Location = new Point(-40, 48);
            dgvProductionOrder.MaxFilterButtonImageHeight = 23;
            dgvProductionOrder.Name = "dgvProductionOrder";
            dgvProductionOrder.RightToLeft = RightToLeft.No;
            dgvProductionOrder.RowTemplate.Height = 25;
            dgvProductionOrder.Size = new Size(624, 224);
            dgvProductionOrder.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            dgvProductionOrder.TabIndex = 6;
            // 
            // stt
            // 
            stt.DataPropertyName = "stt";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            stt.DefaultCellStyle = dataGridViewCellStyle1;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 24;
            stt.Name = "stt";
            stt.SortMode = DataGridViewColumnSortMode.Programmatic;
            stt.Width = 50;
            // 
            // idOrder
            // 
            idOrder.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            idOrder.DefaultCellStyle = dataGridViewCellStyle2;
            idOrder.HeaderText = "ID";
            idOrder.MinimumWidth = 24;
            idOrder.Name = "idOrder";
            idOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            idOrder.Visible = false;
            idOrder.Width = 50;
            // 
            // dateOrder
            // 
            dateOrder.DataPropertyName = "date";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            dateOrder.DefaultCellStyle = dataGridViewCellStyle3;
            dateOrder.HeaderText = "Ngày";
            dateOrder.MinimumWidth = 24;
            dateOrder.Name = "dateOrder";
            dateOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            dateOrder.Visible = false;
            // 
            // modelCodeOrder
            // 
            modelCodeOrder.DataPropertyName = "modelCode";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.NullValue = null;
            modelCodeOrder.DefaultCellStyle = dataGridViewCellStyle4;
            modelCodeOrder.HeaderText = "Model";
            modelCodeOrder.MinimumWidth = 24;
            modelCodeOrder.Name = "modelCodeOrder";
            modelCodeOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            modelCodeOrder.Width = 200;
            // 
            // expectedOutputOrder
            // 
            expectedOutputOrder.DataPropertyName = "expectedOutput";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            expectedOutputOrder.DefaultCellStyle = dataGridViewCellStyle5;
            expectedOutputOrder.HeaderText = "Mục tiêu";
            expectedOutputOrder.MinimumWidth = 24;
            expectedOutputOrder.Name = "expectedOutputOrder";
            expectedOutputOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            expectedOutputOrder.Width = 75;
            // 
            // actualOutputOrder
            // 
            actualOutputOrder.DataPropertyName = "actualOutput";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            actualOutputOrder.DefaultCellStyle = dataGridViewCellStyle6;
            actualOutputOrder.HeaderText = "Thực tế";
            actualOutputOrder.MinimumWidth = 24;
            actualOutputOrder.Name = "actualOutputOrder";
            actualOutputOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            actualOutputOrder.Width = 75;
            // 
            // statusOrder
            // 
            statusOrder.DataPropertyName = "status";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.NullValue = null;
            statusOrder.DefaultCellStyle = dataGridViewCellStyle7;
            statusOrder.HeaderText = "Trạng thái";
            statusOrder.MinimumWidth = 24;
            statusOrder.Name = "statusOrder";
            statusOrder.SortMode = DataGridViewColumnSortMode.Programmatic;
            statusOrder.Width = 180;
            // 
            // circularPanel1
            // 
            circularPanel1.BackColor = Color.FromArgb(255, 128, 128);
            circularPanel1.Location = new Point(16, 223);
            circularPanel1.Name = "circularPanel1";
            circularPanel1.Size = new Size(28, 28);
            circularPanel1.TabIndex = 22;
            // 
            // cpnPlcStatus
            // 
            cpnPlcStatus.BackColor = Color.FromArgb(255, 128, 128);
            cpnPlcStatus.Location = new Point(16, 545);
            cpnPlcStatus.Name = "cpnPlcStatus";
            cpnPlcStatus.Size = new Size(28, 28);
            cpnPlcStatus.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(179, 6);
            label5.Name = "label5";
            label5.Size = new Size(229, 37);
            label5.TabIndex = 20;
            label5.Text = "LỆNH SẢN XUẤT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lbCurrentModel);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-8, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 144);
            panel1.TabIndex = 18;
            // 
            // lbCurrentModel
            // 
            lbCurrentModel.Dock = DockStyle.Fill;
            lbCurrentModel.FlatStyle = FlatStyle.Flat;
            lbCurrentModel.Font = new Font("Segoe UI", 54.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCurrentModel.ForeColor = Color.Black;
            lbCurrentModel.Location = new Point(0, 0);
            lbCurrentModel.Name = "lbCurrentModel";
            lbCurrentModel.Size = new Size(504, 144);
            lbCurrentModel.TabIndex = 0;
            lbCurrentModel.Text = "HWBSJA1021";
            lbCurrentModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 16);
            label6.Name = "label6";
            label6.Size = new Size(196, 65);
            label6.TabIndex = 14;
            label6.Text = "MODEL";
            // 
            // txtCurrentModelOutput
            // 
            txtCurrentModelOutput.AutoSize = true;
            txtCurrentModelOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCurrentModelOutput.Location = new Point(426, 250);
            txtCurrentModelOutput.Name = "txtCurrentModelOutput";
            txtCurrentModelOutput.Size = new Size(53, 32);
            txtCurrentModelOutput.TabIndex = 3;
            txtCurrentModelOutput.Text = "999";
            txtCurrentModelOutput.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(315, 219);
            label3.Name = "label3";
            label3.Size = new Size(164, 30);
            label3.TabIndex = 2;
            label3.Text = "- Model hiện tại";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 527);
            label4.Name = "label4";
            label4.Size = new Size(198, 65);
            label4.TabIndex = 19;
            label4.Text = "Thực tế";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 205);
            label2.Name = "label2";
            label2.Size = new Size(227, 65);
            label2.TabIndex = 13;
            label2.Text = "Mục tiêu";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(500, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(753, 349);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.AutoScrollMargin = new Size(10, 10);
            flowLayoutPanel2.AutoScrollMinSize = new Size(10, 10);
            flowLayoutPanel2.Location = new Point(500, 367);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1352, 519);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // lbMessageToSave
            // 
            lbMessageToSave.AutoSize = true;
            lbMessageToSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMessageToSave.ForeColor = Color.Black;
            lbMessageToSave.Location = new Point(500, 882);
            lbMessageToSave.Name = "lbMessageToSave";
            lbMessageToSave.Size = new Size(16, 21);
            lbMessageToSave.TabIndex = 5;
            lbMessageToSave.Text = "-";
            lbMessageToSave.Visible = false;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.FromArgb(1, 208, 166);
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(label6);
            artanPanel1.Controls.Add(txtCurrentModelOutput);
            artanPanel1.Controls.Add(circularPanel1);
            artanPanel1.Controls.Add(cpnPlcStatus);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(label4);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(panel1);
            artanPanel1.Controls.Add(txtActualOutput);
            artanPanel1.Controls.Add(txtExpectOutput);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.FromArgb(1, 208, 166);
            artanPanel1.GradientTopColor = Color.FromArgb(1, 208, 166);
            artanPanel1.Location = new Point(12, 12);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(482, 877);
            artanPanel1.TabIndex = 7;
            // 
            // txtActualOutput
            // 
            txtActualOutput.BackColor = Color.FromArgb(1, 208, 166);
            txtActualOutput.BorderStyle = BorderStyle.None;
            txtActualOutput.Font = new Font("Arial", 200.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtActualOutput.ForeColor = Color.Black;
            txtActualOutput.Location = new Point(23, 583);
            txtActualOutput.Name = "txtActualOutput";
            txtActualOutput.Size = new Size(434, 308);
            txtActualOutput.TabIndex = 14;
            txtActualOutput.Text = "999";
            // 
            // txtExpectOutput
            // 
            txtExpectOutput.BackColor = Color.FromArgb(1, 208, 166);
            txtExpectOutput.BorderStyle = BorderStyle.None;
            txtExpectOutput.Font = new Font("Arial", 200.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtExpectOutput.ForeColor = Color.Black;
            txtExpectOutput.Location = new Point(23, 265);
            txtExpectOutput.Name = "txtExpectOutput";
            txtExpectOutput.Size = new Size(434, 308);
            txtExpectOutput.TabIndex = 18;
            txtExpectOutput.Text = "999";
            // 
            // artanGradientPanel1
            // 
            artanGradientPanel1.BackColor = Color.FromArgb(119, 80, 159);
            artanGradientPanel1.BorderRadius = 30;
            artanGradientPanel1.Controls.Add(btnCreateNewOrder);
            artanGradientPanel1.Controls.Add(label5);
            artanGradientPanel1.Controls.Add(btnNextModel);
            artanGradientPanel1.Controls.Add(dgvProductionOrder);
            artanGradientPanel1.ForeColor = Color.Black;
            artanGradientPanel1.GradientAngle = 90F;
            artanGradientPanel1.GradientBottomColor = Color.FromArgb(119, 80, 159);
            artanGradientPanel1.GradientTopColor = Color.FromArgb(119, 80, 159);
            artanGradientPanel1.Location = new Point(1259, 22);
            artanGradientPanel1.Name = "artanGradientPanel1";
            artanGradientPanel1.Size = new Size(584, 319);
            artanGradientPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 113, 167);
            panel2.Location = new Point(66, 899);
            panel2.Name = "panel2";
            panel2.Size = new Size(1786, 3);
            panel2.TabIndex = 0;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 233, 241);
            ClientSize = new Size(1864, 901);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lbMessageToSave);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(artanGradientPanel1);
            Controls.Add(artanPanel1);
            Name = "HomeForm";
            Text = "HomeForm";
            ((ISupportInitialize)dgvProductionOrder).EndInit();
            panel1.ResumeLayout(false);
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            artanGradientPanel1.ResumeLayout(false);
            artanGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label lbCurrentModel;
        private Zuby.ADGV.AdvancedDataGridView dgvProductionOrder;
        private Button btnNextModel;
        private Label label2;
        private Button btnCreateNewOrder;
        private Label lbMessageToSave;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private UserControls.CircularPanel circularPanel1;
        private UserControls.CircularPanel cpnPlcStatus;
        private UserControls.ArtanPanel artanPanel1;
        private Label txtCurrentModelOutput;
        private TextBox txtActualOutput;
        private TextBox txtExpectOutput;
        private UserControls.ArtanGradientPanel artanGradientPanel1;
        private Panel panel2;
        private Label label6;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn idOrder;
        private DataGridViewTextBoxColumn dateOrder;
        private DataGridViewTextBoxColumn modelCodeOrder;
        private DataGridViewTextBoxColumn expectedOutputOrder;
        private DataGridViewTextBoxColumn actualOutputOrder;
        private DataGridViewTextBoxColumn statusOrder;
    }
}