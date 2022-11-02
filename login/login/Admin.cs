using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\test.txt";
           
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(txtInfo.Text);
            writer.Close();
        }
    }
}
