namespace HoaPhatApp
{
    partial class AuthenForm
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
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassWord = new TextBox();
            btnAuthen = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(136, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Nhập vào tên tài khoản";
            txtUserName.Size = new Size(206, 29);
            txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(136, 61);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.PlaceholderText = "Nhập vào mật khẩu";
            txtPassWord.Size = new Size(206, 29);
            txtPassWord.TabIndex = 2;
            // 
            // btnAuthen
            // 
            btnAuthen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuthen.Location = new Point(242, 114);
            btnAuthen.Name = "btnAuthen";
            btnAuthen.Size = new Size(100, 35);
            btnAuthen.TabIndex = 4;
            btnAuthen.Text = "Xác thực";
            btnAuthen.UseVisualStyleBackColor = true;
            // 
            // AuthenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 161);
            Controls.Add(btnAuthen);
            Controls.Add(label2);
            Controls.Add(txtPassWord);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Name = "AuthenForm";
            Text = "Xác thực người dùng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private TextBox txtPassWord;
        private Button btnAuthen;
    }
}