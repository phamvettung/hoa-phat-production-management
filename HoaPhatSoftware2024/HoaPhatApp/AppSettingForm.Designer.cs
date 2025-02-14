namespace HoaPhatApp
{
    partial class AppSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingForm));
            artanGradientPanel1 = new UserControls.ArtanGradientPanel();
            label1 = new Label();
            label2 = new Label();
            artanGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // artanGradientPanel1
            // 
            artanGradientPanel1.BackColor = Color.White;
            artanGradientPanel1.BorderRadius = 30;
            artanGradientPanel1.Controls.Add(label2);
            artanGradientPanel1.Controls.Add(label1);
            artanGradientPanel1.ForeColor = Color.Black;
            artanGradientPanel1.GradientAngle = 90F;
            artanGradientPanel1.GradientBottomColor = Color.MediumBlue;
            artanGradientPanel1.GradientTopColor = Color.LightSkyBlue;
            artanGradientPanel1.Location = new Point(12, 12);
            artanGradientPanel1.Name = "artanGradientPanel1";
            artanGradientPanel1.Size = new Size(350, 426);
            artanGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 42);
            label1.Name = "label1";
            label1.Size = new Size(210, 128);
            label1.TabIndex = 0;
            label1.Text = "999";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 195);
            label2.Name = "label2";
            label2.Size = new Size(210, 128);
            label2.TabIndex = 1;
            label2.Text = "999";
            // 
            // AppSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 640);
            Controls.Add(artanGradientPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppSettingForm";
            Text = "Thông tin cài đặt";
            artanGradientPanel1.ResumeLayout(false);
            artanGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UserControls.ArtanGradientPanel artanGradientPanel1;
        private Label label1;
        private Label label2;
    }
}