namespace BankManagement
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(92, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Capitec Bank Management ";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Location = new System.Drawing.Point(47, 75);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.lblBalance.Size = new System.Drawing.Size(103, 27);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Current Balance";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmount.Location = new System.Drawing.Point(47, 134);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Padding = new System.Windows.Forms.Padding(0, 5, 50, 5);
            this.lblAmount.Size = new System.Drawing.Size(103, 27);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            this.lblAmount.UseWaitCursor = true;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLog.Location = new System.Drawing.Point(382, 54);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(125, 21);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "Transaction Log";
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(47, 235);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(75, 23);
            this.btnDebit.TabIndex = 5;
            this.btnDebit.Text = "Debit";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(141, 235);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 23);
            this.btnCredit.TabIndex = 6;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(502, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(175, 135);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Items.AddRange(new object[] {
            "Amount\t\tCurrent Balance"});
            this.lstLog.Location = new System.Drawing.Point(343, 78);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(234, 139);
            this.lstLog.TabIndex = 10;
            // 
            // txtBal
            // 
            this.txtBal.Location = new System.Drawing.Point(175, 77);
            this.txtBal.Name = "txtBal";
            this.txtBal.ReadOnly = true;
            this.txtBal.Size = new System.Drawing.Size(100, 23);
            this.txtBal.TabIndex = 8;
            this.txtBal.TextChanged += new System.EventHandler(this.txtBal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 273);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblBalance;
        private Label lblAmount;
        private Label lblLog;
        private Button btnDebit;
        private Button btnCredit;
        private Button btnReset;
        private TextBox txtAmount;
        private ListBox lstLog;
        private TextBox txtBal;
    }
}