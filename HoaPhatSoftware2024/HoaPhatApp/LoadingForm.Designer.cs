namespace HoaPhatApp
{
    partial class LoadingForm
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
            pictureBox1 = new PictureBox();
            lbMessage = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.loading;
            pictureBox1.Location = new Point(110, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbMessage
            // 
            lbMessage.Dock = DockStyle.Fill;
            lbMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMessage.ForeColor = Color.SteelBlue;
            lbMessage.Location = new Point(0, 0);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(300, 30);
            lbMessage.TabIndex = 1;
            lbMessage.Text = "Message";
            lbMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(53, 123);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 2;
            label2.Text = "Vui lòng chờ trong giây lát";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 5);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbMessage);
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 30);
            panel2.TabIndex = 4;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 150);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbMessage;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}