namespace Willemse_Dale_PRG282_MockTest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEmployees = new System.Windows.Forms.ListView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFormatted = new System.Windows.Forms.Button();
            this.lstFormatted = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(408, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID";
            // 
            // lstEmployees
            // 
            this.lstEmployees.Location = new System.Drawing.Point(326, 34);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(413, 118);
            this.lstEmployees.TabIndex = 2;
            this.lstEmployees.UseCompatibleStateImageBehavior = false;
            this.lstEmployees.View = System.Windows.Forms.View.List;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(130, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 23);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 23);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 129);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(155, 23);
            this.txtSurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFormatted
            // 
            this.btnFormatted.Location = new System.Drawing.Point(95, 302);
            this.btnFormatted.Name = "btnFormatted";
            this.btnFormatted.Size = new System.Drawing.Size(115, 52);
            this.btnFormatted.TabIndex = 8;
            this.btnFormatted.Text = "Display in New Format";
            this.btnFormatted.UseVisualStyleBackColor = true;
            this.btnFormatted.Click += new System.EventHandler(this.btnFormatted_Click);
            // 
            // lstFormatted
            // 
            this.lstFormatted.Location = new System.Drawing.Point(241, 265);
            this.lstFormatted.Name = "lstFormatted";
            this.lstFormatted.Size = new System.Drawing.Size(498, 132);
            this.lstFormatted.TabIndex = 9;
            this.lstFormatted.UseCompatibleStateImageBehavior = false;
            this.lstFormatted.View = System.Windows.Forms.View.List;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstFormatted);
            this.Controls.Add(this.btnFormatted);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Label label1;
        private ListView lstEmployees;
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtSurname;
        private Label label3;
        private Button btnAdd;
        private Button btnFormatted;
        private ListView lstFormatted;
        private Button btnExit;
    }
}