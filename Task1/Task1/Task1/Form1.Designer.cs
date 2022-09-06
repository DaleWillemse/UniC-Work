namespace Task1
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTransactionLog = new System.Windows.Forms.Label();
            this.lblCapitecBank = new System.Windows.Forms.Label();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgwTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(61, 125);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(62, 96);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(91, 15);
            this.lblCurrentBalance.TabIndex = 1;
            this.lblCurrentBalance.Text = "Current Balance";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(176, 93);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 23);
            this.txtCurrentBalance.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(176, 122);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblTransactionLog
            // 
            this.lblTransactionLog.AutoSize = true;
            this.lblTransactionLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransactionLog.Location = new System.Drawing.Point(386, 43);
            this.lblTransactionLog.Name = "lblTransactionLog";
            this.lblTransactionLog.Size = new System.Drawing.Size(114, 19);
            this.lblTransactionLog.TabIndex = 4;
            this.lblTransactionLog.Text = "Transaction Log";
            // 
            // lblCapitecBank
            // 
            this.lblCapitecBank.AutoSize = true;
            this.lblCapitecBank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapitecBank.Location = new System.Drawing.Point(199, 8);
            this.lblCapitecBank.Name = "lblCapitecBank";
            this.lblCapitecBank.Size = new System.Drawing.Size(215, 21);
            this.lblCapitecBank.TabIndex = 5;
            this.lblCapitecBank.Text = "Capitec Bank Management";
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(78, 243);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(75, 23);
            this.btnDebit.TabIndex = 7;
            this.btnDebit.Text = "Debit";
            this.btnDebit.UseVisualStyleBackColor = true;
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(176, 243);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 23);
            this.btnCredit.TabIndex = 8;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(465, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dgwTransactions
            // 
            this.dgwTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTransactions.Location = new System.Drawing.Point(316, 65);
            this.dgwTransactions.Name = "dgwTransactions";
            this.dgwTransactions.RowTemplate.Height = 25;
            this.dgwTransactions.Size = new System.Drawing.Size(240, 150);
            this.dgwTransactions.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 304);
            this.Controls.Add(this.dgwTransactions);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.lblCapitecBank);
            this.Controls.Add(this.lblTransactionLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAmount;
        private Label lblCurrentBalance;
        private TextBox txtCurrentBalance;
        private TextBox txtAmount;
        private Label label1;
        private Label lblTransactionLog;
        private Label lblCapitecBank;
        private Button btnDebit;
        private Button btnCredit;
        private Button btnReset;
        private DataGridView dgwTransactions;
    }
}