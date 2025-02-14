namespace HoaPhatApp
{
    partial class ModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelForm));
            label1 = new Label();
            lbModelName = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            numToLerance = new NumericUpDown();
            numGrossWeight = new NumericUpDown();
            txtModelName = new TextBox();
            txtModelCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numToLerance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGrossWeight).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(214, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 0;
            label1.Text = "Model";
            // 
            // lbModelName
            // 
            lbModelName.AutoSize = true;
            lbModelName.BackColor = Color.Transparent;
            lbModelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbModelName.ForeColor = Color.Black;
            lbModelName.Location = new Point(297, 23);
            lbModelName.Name = "lbModelName";
            lbModelName.Size = new Size(135, 30);
            lbModelName.TabIndex = 1;
            lbModelName.Text = "model name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(numToLerance);
            panel1.Controls.Add(numGrossWeight);
            panel1.Controls.Add(txtModelName);
            panel1.Controls.Add(txtModelCode);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 335);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(595, 281);
            label8.Name = "label8";
            label8.Size = new Size(22, 30);
            label8.TabIndex = 12;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(595, 213);
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
            label6.Location = new Point(595, 71);
            label6.Name = "label6";
            label6.Size = new Size(22, 30);
            label6.TabIndex = 10;
            label6.Text = "*";
            // 
            // numToLerance
            // 
            numToLerance.BackColor = SystemColors.GradientInactiveCaption;
            numToLerance.BorderStyle = BorderStyle.None;
            numToLerance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numToLerance.Location = new Point(385, 282);
            numToLerance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numToLerance.Name = "numToLerance";
            numToLerance.Size = new Size(204, 29);
            numToLerance.TabIndex = 9;
            // 
            // numGrossWeight
            // 
            numGrossWeight.BackColor = SystemColors.GradientInactiveCaption;
            numGrossWeight.BorderStyle = BorderStyle.None;
            numGrossWeight.DecimalPlaces = 3;
            numGrossWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            numGrossWeight.Location = new Point(385, 214);
            numGrossWeight.Name = "numGrossWeight";
            numGrossWeight.Size = new Size(204, 29);
            numGrossWeight.TabIndex = 8;
            // 
            // txtModelName
            // 
            txtModelName.BackColor = SystemColors.GradientInactiveCaption;
            txtModelName.BorderStyle = BorderStyle.None;
            txtModelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelName.Location = new Point(17, 146);
            txtModelName.Name = "txtModelName";
            txtModelName.PlaceholderText = "Nhập vào tên model...";
            txtModelName.Size = new Size(572, 26);
            txtModelName.TabIndex = 7;
            // 
            // txtModelCode
            // 
            txtModelCode.BackColor = SystemColors.GradientInactiveCaption;
            txtModelCode.BorderStyle = BorderStyle.None;
            txtModelCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelCode.Location = new Point(17, 75);
            txtModelCode.Name = "txtModelCode";
            txtModelCode.PlaceholderText = "Nhập vào mã model...";
            txtModelCode.Size = new Size(572, 26);
            txtModelCode.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 282);
            label5.Name = "label5";
            label5.Size = new Size(202, 30);
            label5.TabIndex = 5;
            label5.Text = "Sai số cho phép (g):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 214);
            label4.Name = "label4";
            label4.Size = new Size(237, 30);
            label4.TabIndex = 4;
            label4.Text = "Khối lượng cài đặt (kg):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 3;
            label3.Text = "Tên Model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 2;
            label2.Text = "Mã Model:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSkyBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(330, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSkyBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(436, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSkyBlue;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(542, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.background_menu;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbModelName);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 60);
            panel2.TabIndex = 15;
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
            panel3.Size = new Size(654, 5);
            panel3.TabIndex = 0;
            // 
            // ModelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(654, 456);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ModelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm - Sửa - Xóa Model";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numToLerance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGrossWeight).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lbModelName;
        private Panel panel1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtModelName;
        private TextBox txtModelCode;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numToLerance;
        private NumericUpDown numGrossWeight;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
    }
}