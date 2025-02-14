namespace HoaPhatApp
{
    partial class OperatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorForm));
            btnOk = new Button();
            panel1 = new Panel();
            txtOperatorName = new RichTextBox();
            cboIgnore = new CheckBox();
            label4 = new Label();
            txtExcutionTime = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbModelName = new Label();
            label1 = new Label();
            lbNumOperator = new Label();
            label10 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.LightSkyBlue;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.ImageAlign = ContentAlignment.MiddleLeft;
            btnOk.Location = new Point(518, 283);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 35);
            btnOk.TabIndex = 9;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtOperatorName);
            panel1.Controls.Add(cboIgnore);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtExcutionTime);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 205);
            panel1.TabIndex = 8;
            // 
            // txtOperatorName
            // 
            txtOperatorName.BackColor = SystemColors.Control;
            txtOperatorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOperatorName.Location = new Point(17, 47);
            txtOperatorName.Name = "txtOperatorName";
            txtOperatorName.Size = new Size(577, 48);
            txtOperatorName.TabIndex = 16;
            txtOperatorName.Text = "";
            // 
            // cboIgnore
            // 
            cboIgnore.AutoSize = true;
            cboIgnore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboIgnore.Location = new Point(426, 165);
            cboIgnore.Name = "cboIgnore";
            cboIgnore.Size = new Size(140, 29);
            cboIgnore.TabIndex = 15;
            cboIgnore.Text = "Chọn bỏ qua";
            cboIgnore.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 159);
            label4.Name = "label4";
            label4.Size = new Size(199, 30);
            label4.TabIndex = 14;
            label4.Text = "Bỏ qua công đoạn?";
            // 
            // txtExcutionTime
            // 
            txtExcutionTime.BackColor = SystemColors.Control;
            txtExcutionTime.BorderStyle = BorderStyle.None;
            txtExcutionTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtExcutionTime.Location = new Point(426, 120);
            txtExcutionTime.Name = "txtExcutionTime";
            txtExcutionTime.PlaceholderText = "HH:mm:ss";
            txtExcutionTime.Size = new Size(140, 26);
            txtExcutionTime.TabIndex = 13;
            txtExcutionTime.Text = "00:00:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(572, 159);
            label7.Name = "label7";
            label7.Size = new Size(22, 30);
            label7.TabIndex = 11;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(572, 116);
            label6.Name = "label6";
            label6.Size = new Size(22, 30);
            label6.TabIndex = 10;
            label6.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 3;
            label3.Text = "Thời gian thực hiện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 11);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 2;
            label2.Text = "Tên công đoạn:";
            // 
            // lbModelName
            // 
            lbModelName.AutoSize = true;
            lbModelName.BackColor = Color.Transparent;
            lbModelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbModelName.ForeColor = Color.Black;
            lbModelName.Location = new Point(291, 22);
            lbModelName.Name = "lbModelName";
            lbModelName.Size = new Size(135, 30);
            lbModelName.TabIndex = 7;
            lbModelName.Text = "model name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(213, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 6;
            label1.Text = "Model";
            // 
            // lbNumOperator
            // 
            lbNumOperator.AutoSize = true;
            lbNumOperator.BackColor = Color.Transparent;
            lbNumOperator.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumOperator.ForeColor = Color.Black;
            lbNumOperator.Location = new Point(591, 22);
            lbNumOperator.Name = "lbNumOperator";
            lbNumOperator.Size = new Size(25, 30);
            lbNumOperator.TabIndex = 13;
            lbNumOperator.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(465, 22);
            label10.Name = "label10";
            label10.Size = new Size(115, 30);
            label10.TabIndex = 12;
            label10.Text = "Công đoạn";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.background_menu;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbNumOperator);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbModelName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 60);
            panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 5);
            panel3.TabIndex = 0;
            // 
            // OperatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(630, 325);
            Controls.Add(panel2);
            Controls.Add(btnOk);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OperatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cài đặt Công đoạn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOk;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label lbModelName;
        private Label label1;
        private Label lbNumOperator;
        private Label label10;
        private Label label4;
        private TextBox txtExcutionTime;
        private CheckBox cboIgnore;
        private RichTextBox txtOperatorName;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}