namespace Client.FromLs
{
    partial class Register
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
            lbTitle = new Label();
            lbPass = new Label();
            lbPhone = new Label();
            txtPass = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            lbFullname = new Label();
            lbBirthday = new Label();
            txtFullname = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            txtBirthday = new DateTimePicker();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F);
            lbTitle.Location = new Point(317, 97);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(182, 59);
            lbTitle.TabIndex = 11;
            lbTitle.Text = "Đăng Ký";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(182, 230);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(115, 32);
            lbPass.TabIndex = 10;
            lbPass.Text = "Mật khẩu";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(141, 185);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(156, 32);
            lbPhone.TabIndex = 9;
            lbPhone.Text = "Số điện thoại";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(303, 223);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(255, 39);
            txtPass.TabIndex = 8;
            txtPass.PasswordChar = '*';
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(303, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(255, 39);
            txtPhone.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(252, 457);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 46);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Đăng Ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(408, 457);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 12;
            btnBack.Text = "Trở về";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(182, 320);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(118, 32);
            lbFullname.TabIndex = 16;
            lbFullname.Text = "Họ và tên";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(176, 275);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(121, 32);
            lbBirthday.TabIndex = 15;
            lbBirthday.Text = "Ngày sinh";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(303, 313);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(255, 39);
            txtFullname.TabIndex = 14;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(226, 365);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 18;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 358);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 39);
            txtEmail.TabIndex = 17;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(303, 268);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(255, 39);
            txtBirthday.Format = DateTimePickerFormat.Custom;
            txtBirthday.CustomFormat = "dd/MM/yyyy";
            txtBirthday.TabIndex = 19;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(txtBirthday);
            Controls.Add(lbEmail);
            Controls.Add(txtEmail);
            Controls.Add(lbFullname);
            Controls.Add(lbBirthday);
            Controls.Add(txtFullname);
            Controls.Add(btnBack);
            Controls.Add(lbTitle);
            Controls.Add(lbPass);
            Controls.Add(lbPhone);
            Controls.Add(txtPass);
            Controls.Add(txtPhone);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Register";
            FormClosing += click_Closing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbPass;
        private Label lbPhone;
        private TextBox txtPass;
        private TextBox txtPhone;
        private Button btnRegister;
        private Button btnBack;
        private Label lbFullname;
        private Label lbBirthday;
        private TextBox txtFullname;
        private Label lbEmail;
        private TextBox txtEmail;
        private DateTimePicker txtBirthday;
    }
}