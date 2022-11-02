namespace listExercise
{
    partial class ListExercise
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListView();
            this.lstSort = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(66, 54);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(131, 43);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Data";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(289, 54);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(131, 43);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort Ascending";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstData
            // 
            this.lstData.Location = new System.Drawing.Point(66, 129);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(131, 173);
            this.lstData.TabIndex = 2;
            this.lstData.TileSize = new System.Drawing.Size(228, 34);
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.List;
            // 
            // lstSort
            // 
            this.lstSort.Location = new System.Drawing.Point(289, 129);
            this.lstSort.Name = "lstSort";
            this.lstSort.Size = new System.Drawing.Size(131, 173);
            this.lstSort.TabIndex = 3;
            this.lstSort.UseCompatibleStateImageBehavior = false;
            this.lstSort.View = System.Windows.Forms.View.List;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ListExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstSort);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRead);
            this.Name = "ListExercise";
            this.Text = "ListExercise";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRead;
        private Button btnSort;
        private ListView lstData;
        private ListView lstSort;
        private Button btnExit;
    }
}