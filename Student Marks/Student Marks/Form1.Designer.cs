namespace Student_Marks
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnViewPart = new System.Windows.Forms.Button();
            this.btnViewFull = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpNav = new System.Windows.Forms.GroupBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchStudentNumber = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpNav.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MARKS SYSTEM";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.colAverage,
            this.colResults,
            this.colFees,
            this.colPayment});
            this.dgvStudents.Location = new System.Drawing.Point(12, 57);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 25;
            this.dgvStudents.Size = new System.Drawing.Size(580, 234);
            this.dgvStudents.TabIndex = 1;
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "StudNumber";
            this.colNumber.Name = "colNumber";
            // 
            // colName
            // 
            this.colName.HeaderText = "StudName";
            this.colName.Name = "colName";
            // 
            // colAverage
            // 
            this.colAverage.FillWeight = 70F;
            this.colAverage.HeaderText = "Average";
            this.colAverage.Name = "colAverage";
            // 
            // colResults
            // 
            this.colResults.HeaderText = "Results";
            this.colResults.Name = "colResults";
            // 
            // colFees
            // 
            this.colFees.HeaderText = "Fees";
            this.colFees.Name = "colFees";
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Payment";
            this.colPayment.Name = "colPayment";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(605, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.Location = new System.Drawing.Point(9, 27);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(173, 45);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View All Students";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnViewPart
            // 
            this.btnViewPart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewPart.Location = new System.Drawing.Point(9, 78);
            this.btnViewPart.Name = "btnViewPart";
            this.btnViewPart.Size = new System.Drawing.Size(173, 45);
            this.btnViewPart.TabIndex = 4;
            this.btnViewPart.Text = "View Part Time";
            this.btnViewPart.UseVisualStyleBackColor = true;
            // 
            // btnViewFull
            // 
            this.btnViewFull.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewFull.Location = new System.Drawing.Point(9, 129);
            this.btnViewFull.Name = "btnViewFull";
            this.btnViewFull.Size = new System.Drawing.Size(173, 45);
            this.btnViewFull.TabIndex = 5;
            this.btnViewFull.Text = "View Full Time";
            this.btnViewFull.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(19, 37);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 34);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLast.Location = new System.Drawing.Point(149, 37);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(108, 34);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirst.Location = new System.Drawing.Point(280, 37);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(108, 34);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(410, 37);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 34);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // grpNav
            // 
            this.grpNav.Controls.Add(this.btnNext);
            this.grpNav.Controls.Add(this.btnPrevious);
            this.grpNav.Controls.Add(this.btnLast);
            this.grpNav.Controls.Add(this.btnFirst);
            this.grpNav.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpNav.Location = new System.Drawing.Point(33, 297);
            this.grpNav.Name = "grpNav";
            this.grpNav.Size = new System.Drawing.Size(537, 99);
            this.grpNav.TabIndex = 10;
            this.grpNav.TabStop = false;
            this.grpNav.Text = "Navigation";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.btnViewFull);
            this.grpMenu.Controls.Add(this.btnView);
            this.grpMenu.Controls.Add(this.btnViewPart);
            this.grpMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpMenu.Location = new System.Drawing.Point(598, 75);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(190, 195);
            this.grpMenu.TabIndex = 11;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Display Buttons";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearchStudentNumber);
            this.grpSearch.Controls.Add(this.textBox1);
            this.grpSearch.Controls.Add(this.label7);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpSearch.Location = new System.Drawing.Point(598, 276);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(190, 120);
            this.grpSearch.TabIndex = 12;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Student";
            // 
            // btnSearchStudentNumber
            // 
            this.btnSearchStudentNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStudentNumber.Location = new System.Drawing.Point(9, 86);
            this.btnSearchStudentNumber.Name = "btnSearchStudentNumber";
            this.btnSearchStudentNumber.Size = new System.Drawing.Size(171, 25);
            this.btnSearchStudentNumber.TabIndex = 10;
            this.btnSearchStudentNumber.Text = "Search Student";
            this.btnSearchStudentNumber.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(9, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(33, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Enter Student Number";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblMark);
            this.grpDetails.Controls.Add(this.lblPayment);
            this.grpDetails.Controls.Add(this.lblResults);
            this.grpDetails.Controls.Add(this.lblFees);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.Location = new System.Drawing.Point(33, 411);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(733, 75);
            this.grpDetails.TabIndex = 13;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Student Details";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMark.Location = new System.Drawing.Point(221, 48);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(34, 15);
            this.lblMark.TabIndex = 9;
            this.lblMark.Text = "Mark";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(607, 48);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(54, 15);
            this.lblPayment.TabIndex = 8;
            this.lblPayment.Text = "Payment";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResults.Location = new System.Drawing.Point(342, 48);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(44, 15);
            this.lblResults.TabIndex = 7;
            this.lblResults.Text = "Results";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFees.Location = new System.Drawing.Point(477, 48);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(30, 15);
            this.lblFees.TabIndex = 6;
            this.lblFees.Text = "Fees";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(38, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Student Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(221, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(607, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(342, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(477, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(38, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.grpNav);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpNav.ResumeLayout(false);
            this.grpMenu.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvStudents;
        private Button btnExit;
        private Button btnView;
        private Button btnViewPart;
        private Button btnViewFull;
        private Button btnPrevious;
        private Button btnLast;
        private Button btnFirst;
        private Button btnNext;
        private GroupBox grpNav;
        private GroupBox grpMenu;
        private GroupBox grpSearch;
        private GroupBox grpDetails;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblMark;
        private Label lblPayment;
        private Label lblResults;
        private Label lblFees;
        private Label lblName;
        private Button btnSearchStudentNumber;
        private TextBox textBox1;
        private Label label7;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colAverage;
        private DataGridViewTextBoxColumn colResults;
        private DataGridViewTextBoxColumn colFees;
        private DataGridViewTextBoxColumn colPayment;
    }
}