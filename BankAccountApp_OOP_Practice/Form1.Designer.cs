namespace BankAccountApp_OOP_Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOwner = new Label();
            ttbOwner = new TextBox();
            btnCreateAcc = new Button();
            lblAmount = new Label();
            nudAmount = new NumericUpDown();
            gridBank = new DataGridView();
            btnDeposit = new Button();
            btnWithdraw = new Button();
            lblInterest = new Label();
            nudInterest = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridBank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInterest).BeginInit();
            SuspendLayout();
            // 
            // lblOwner
            // 
            lblOwner.AutoSize = true;
            lblOwner.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOwner.Location = new Point(83, 76);
            lblOwner.Margin = new Padding(5, 0, 5, 0);
            lblOwner.Name = "lblOwner";
            lblOwner.Size = new Size(86, 31);
            lblOwner.TabIndex = 0;
            lblOwner.Text = "Owner:";
            // 
            // ttbOwner
            // 
            ttbOwner.Location = new Point(192, 76);
            ttbOwner.Margin = new Padding(5);
            ttbOwner.Name = "ttbOwner";
            ttbOwner.Size = new Size(298, 38);
            ttbOwner.TabIndex = 1;
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.BackColor = Color.Silver;
            btnCreateAcc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAcc.Location = new Point(192, 219);
            btnCreateAcc.Margin = new Padding(5);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(298, 60);
            btnCreateAcc.TabIndex = 2;
            btnCreateAcc.Text = "Create Account";
            btnCreateAcc.UseVisualStyleBackColor = false;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(83, 414);
            lblAmount.Margin = new Padding(5, 0, 5, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(101, 31);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "Amount:";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(192, 412);
            nudAmount.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(298, 38);
            nudAmount.TabIndex = 4;
            // 
            // gridBank
            // 
            gridBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridBank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBank.Location = new Point(581, 76);
            gridBank.Name = "gridBank";
            gridBank.RowHeadersWidth = 51;
            gridBank.Size = new Size(691, 334);
            gridBank.TabIndex = 5;
            gridBank.CellContentClick += gridBank_CellContentClick;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.Silver;
            btnDeposit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeposit.Location = new Point(581, 418);
            btnDeposit.Margin = new Padding(5);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(344, 48);
            btnDeposit.TabIndex = 6;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.Silver;
            btnWithdraw.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdraw.Location = new Point(926, 418);
            btnWithdraw.Margin = new Padding(5);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(346, 48);
            btnWithdraw.TabIndex = 7;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // lblInterest
            // 
            lblInterest.AutoSize = true;
            lblInterest.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInterest.Location = new Point(192, 147);
            lblInterest.Margin = new Padding(5, 0, 5, 0);
            lblInterest.Name = "lblInterest";
            lblInterest.Size = new Size(187, 31);
            lblInterest.TabIndex = 8;
            lblInterest.Text = "Interest Rate (%):";
            // 
            // nudInterest
            // 
            nudInterest.Location = new Point(387, 145);
            nudInterest.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            nudInterest.Name = "nudInterest";
            nudInterest.Size = new Size(103, 38);
            nudInterest.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1300, 480);
            Controls.Add(nudInterest);
            Controls.Add(lblInterest);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Controls.Add(gridBank);
            Controls.Add(nudAmount);
            Controls.Add(lblAmount);
            Controls.Add(btnCreateAcc);
            Controls.Add(ttbOwner);
            Controls.Add(lblOwner);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridBank).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInterest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOwner;
        private TextBox ttbOwner;
        private Button btnCreateAcc;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private DataGridView gridBank;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Label lblInterest;
        private NumericUpDown nudInterest;
    }
}
