using System.ComponentModel;

namespace Client.FromLs
{
    partial class Home
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

        // Form2.Designer.cs
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pnHisBet = new TableLayoutPanel();
            dtgvHisBet = new DataGridView();
            btnBetPre = new Button();
            btnBetNext = new Button();
            lbBetPage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNext = new Button();
            dtgvHisResult = new DataGridView();
            btnPrevious = new Button();
            lblPageNumber = new Label();
            panel3 = new Panel();
            lbResult = new Label();
            lbNext = new Label();
            lbNow = new Label();
            lbCd = new Label();
            panel2 = new Panel();
            txtBirthday = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            btnBet = new Button();
            txtFullname = new TextBox();
            lbBirthday = new Label();
            lbFullname = new Label();
            btnLogout = new Button();
            txtPhone = new TextBox();
            lbPhone = new Label();
            lbTitle = new Label();
            panel1.SuspendLayout();
            pnHisBet.SuspendLayout();
            ((ISupportInitialize)dtgvHisBet).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)dtgvHisResult).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnHisBet);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1670, 887);
            panel1.TabIndex = 0;
            // 
            // pnHisBet
            // 
            pnHisBet.ColumnCount = 3;
            pnHisBet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnHisBet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnHisBet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnHisBet.Controls.Add(dtgvHisBet, 0, 0);
            pnHisBet.Controls.Add(btnBetPre, 2, 1);
            pnHisBet.Controls.Add(btnBetNext, 0, 1);
            pnHisBet.Controls.Add(lbBetPage, 1, 1);
            pnHisBet.Location = new Point(1058, 247);
            pnHisBet.Name = "pnHisBet";
            pnHisBet.RowCount = 2;
            pnHisBet.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnHisBet.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            pnHisBet.Size = new Size(606, 634);
            pnHisBet.TabIndex = 28;
            // 
            // dtgvHisBet
            // 
            dtgvHisBet.AllowUserToAddRows = false;
            dtgvHisBet.AllowUserToDeleteRows = false;
            dtgvHisBet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pnHisBet.SetColumnSpan(dtgvHisBet, 3);
            dtgvHisBet.Dock = DockStyle.Fill;
            dtgvHisBet.Location = new Point(3, 3);
            dtgvHisBet.Name = "dtgvHisBet";
            dtgvHisBet.ReadOnly = true;
            dtgvHisBet.RowHeadersWidth = 82;
            dtgvHisBet.Size = new Size(600, 563);
            dtgvHisBet.TabIndex = 0;
            // 
            // btnBetPre
            // 
            btnBetPre.Anchor = AnchorStyles.Left;
            btnBetPre.Location = new Point(426, 582);
            btnBetPre.Name = "btnBetPre";
            btnBetPre.Size = new Size(123, 39);
            btnBetPre.TabIndex = 20;
            btnBetPre.Text = "Sau";
            btnBetPre.UseVisualStyleBackColor = true;
            btnBetPre.Click += btnBetPre_Click;
            // 
            // btnBetNext
            // 
            btnBetNext.Anchor = AnchorStyles.Right;
            btnBetNext.Location = new Point(55, 582);
            btnBetNext.Name = "btnBetNext";
            btnBetNext.Size = new Size(123, 39);
            btnBetNext.TabIndex = 19;
            btnBetNext.Text = "Trước";
            btnBetNext.UseVisualStyleBackColor = true;
            btnBetNext.Click += btnBetNext_Click;
            // 
            // lbBetPage
            // 
            lbBetPage.Anchor = AnchorStyles.None;
            lbBetPage.AutoSize = true;
            lbBetPage.Location = new Point(302, 585);
            lbBetPage.Name = "lbBetPage";
            lbBetPage.Size = new Size(0, 32);
            lbBetPage.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(btnNext, 2, 1);
            tableLayoutPanel1.Controls.Add(dtgvHisResult, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrevious, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPageNumber, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 244);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(1023, 637);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Left;
            btnNext.Location = new Point(718, 585);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 39);
            btnNext.TabIndex = 20;
            btnNext.Text = "Sau";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dtgvHisResult
            // 
            dtgvHisResult.AllowUserToAddRows = false;
            dtgvHisResult.AllowUserToDeleteRows = false;
            dtgvHisResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dtgvHisResult, 3);
            dtgvHisResult.Dock = DockStyle.Fill;
            dtgvHisResult.Location = new Point(3, 3);
            dtgvHisResult.Name = "dtgvHisResult";
            dtgvHisResult.ReadOnly = true;
            dtgvHisResult.RowHeadersWidth = 82;
            dtgvHisResult.Size = new Size(1017, 566);
            dtgvHisResult.TabIndex = 0;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Right;
            btnPrevious.Location = new Point(180, 585);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(123, 39);
            btnPrevious.TabIndex = 19;
            btnPrevious.Text = "Trước";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.Anchor = AnchorStyles.None;
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(510, 588);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(0, 32);
            lblPageNumber.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbResult);
            panel3.Controls.Add(lbNext);
            panel3.Controls.Add(lbNow);
            panel3.Controls.Add(lbCd);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1023, 235);
            panel3.TabIndex = 24;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 16F);
            lbResult.Location = new Point(384, 121);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(0, 59);
            lbResult.TabIndex = 24;
            // 
            // lbNext
            // 
            lbNext.AutoSize = true;
            lbNext.Font = new Font("Segoe UI", 16F);
            lbNext.Location = new Point(161, 48);
            lbNext.Name = "lbNext";
            lbNext.Size = new Size(0, 59);
            lbNext.TabIndex = 19;
            // 
            // lbNow
            // 
            lbNow.AutoSize = true;
            lbNow.Font = new Font("Segoe UI", 16F);
            lbNow.Location = new Point(161, 117);
            lbNow.Name = "lbNow";
            lbNow.Size = new Size(0, 59);
            lbNow.TabIndex = 20;
            // 
            // lbCd
            // 
            lbCd.AutoSize = true;
            lbCd.Font = new Font("Segoe UI", 16F);
            lbCd.Location = new Point(384, 48);
            lbCd.Name = "lbCd";
            lbCd.Size = new Size(0, 59);
            lbCd.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBirthday);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(btnBet);
            panel2.Controls.Add(txtFullname);
            panel2.Controls.Add(lbBirthday);
            panel2.Controls.Add(lbFullname);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(lbPhone);
            panel2.Controls.Add(lbTitle);
            panel2.Location = new Point(1058, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 235);
            panel2.TabIndex = 0;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(406, 93);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(200, 39);
            txtBirthday.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(406, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 24;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(218, 144);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(76, 32);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "Email:";
            // 
            // btnBet
            // 
            btnBet.Location = new Point(3, 188);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(123, 39);
            btnBet.TabIndex = 18;
            btnBet.Text = "Mua vé";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Click += btnBet_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(406, 48);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(200, 39);
            txtFullname.TabIndex = 22;
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(218, 98);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(107, 32);
            lbBirthday.TabIndex = 21;
            lbBirthday.Text = "Birthday:";
            // 
            // lbFullname
            // 
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(218, 51);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(128, 32);
            lbFullname.TabIndex = 20;
            lbFullname.Text = "Full Name:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(455, 189);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(151, 38);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(406, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(200, 39);
            txtPhone.TabIndex = 17;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(218, 3);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(182, 32);
            lbPhone.TabIndex = 15;
            lbPhone.Text = "Phone Number:";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(3, 3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(118, 32);
            lbTitle.TabIndex = 13;
            lbTitle.Text = "Thông tin";
            // 
            // Home
            // 
            ClientSize = new Size(1694, 911);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Trang Chủ";
            FormClosing += click_Closing;
            panel1.ResumeLayout(false);
            pnHisBet.ResumeLayout(false);
            pnHisBet.PerformLayout();
            ((ISupportInitialize)dtgvHisBet).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((ISupportInitialize)dtgvHisResult).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Home numSlotTime;
        private Home numNumber;

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtBirthday;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtFullname;
        private Label lbBirthday;
        private Label lbFullname;
        private Button btnLogout;
        private Button btnBet;
        private TextBox txtPhone;
        private Label lbPhone;
        private Label lbTitle;
        private Label lbCd;
        private Label lbNow;
        private Label lbNext;
        private Panel panel3;
        private Label lbResult;
        private DataGridView dtgvHisBet;
        private Button btnNext;
        private Button btnPrevious;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgvHisResult;
        private Label lblPageNumber;
        private TableLayoutPanel pnHisBet;
        private Button btnBetPre;
        private Button btnBetNext;
        private Label lbBetPage;
    }
}