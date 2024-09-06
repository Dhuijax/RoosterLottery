namespace Client.FromLs
{
    partial class Bet
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbBet = new Label();
            txtBet = new TextBox();
            btnBet = new Button();
            lbGuide = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lbBet, 1, 0);
            tableLayoutPanel1.Controls.Add(txtBet, 1, 1);
            tableLayoutPanel1.Controls.Add(btnBet, 1, 2);
            tableLayoutPanel1.Controls.Add(lbGuide, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbBet
            // 
            lbBet.Anchor = AnchorStyles.Bottom;
            lbBet.AutoSize = true;
            lbBet.Font = new Font("Segoe UI", 16F);
            lbBet.Location = new Point(277, 101);
            lbBet.Margin = new Padding(5, 5, 5, 10);
            lbBet.Name = "lbBet";
            lbBet.Size = new Size(220, 59);
            lbBet.TabIndex = 0;
            lbBet.Text = "Mua vé số";
            // 
            // txtBet
            // 
            txtBet.Anchor = AnchorStyles.None;
            txtBet.Location = new Point(287, 182);
            txtBet.Margin = new Padding(3, 10, 3, 10);
            txtBet.Name = "txtBet";
            txtBet.Size = new Size(200, 39);
            txtBet.TabIndex = 1;
            // 
            // btnBet
            // 
            btnBet.Anchor = AnchorStyles.Top;
            btnBet.Location = new Point(322, 253);
            btnBet.Margin = new Padding(3, 20, 3, 3);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(130, 55);
            btnBet.TabIndex = 2;
            btnBet.Text = "Mua vé";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Click += btnBet_Click;
            // 
            // lbGuide
            // 
            lbGuide.Anchor = AnchorStyles.Right;
            lbGuide.AutoSize = true;
            lbGuide.Location = new Point(35, 185);
            lbGuide.Name = "lbGuide";
            lbGuide.Size = new Size(220, 32);
            lbGuide.TabIndex = 3;
            lbGuide.Text = "Nhập số từ 0 đến 9";
            // 
            // Bet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormClosing += click_Closing;
            Name = "Bet";
            Text = "Mua vé số";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbBet;
        private TextBox txtBet;
        private Button btnBet;
        private Label lbGuide;
    }
}