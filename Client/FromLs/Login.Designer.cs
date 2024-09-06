namespace Client.FromLs
{
    partial class Login
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
            btnLogin = new Button();
            txtPhone = new TextBox();
            txtPass = new TextBox();
            lbPhone = new Label();
            lbPass = new Label();
            lbTitle = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(252, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(317, 141);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 39);
            txtPhone.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(317, 186);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(200, 39);
            txtPass.TabIndex = 2;
            txtPass.PasswordChar = '*';
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(155, 141);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(156, 32);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Số điện thoại";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(196, 193);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(115, 32);
            lbPass.TabIndex = 4;
            lbPass.Text = "Mật khẩu";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F);
            lbTitle.Location = new Point(298, 58);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(241, 59);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Đăng Nhập";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(408, 283);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 46);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(lbTitle);
            Controls.Add(lbPass);
            Controls.Add(lbPhone);
            Controls.Add(txtPass);
            Controls.Add(txtPhone);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            FormClosing += click_Closing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPhone;
        private TextBox txtPass;
        private Label lbPhone;
        private Label lbPass;
        private Label lbTitle;
        private Button btnRegister;
    }
}