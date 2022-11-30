using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Willemse_Dale_PRG2782_EXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string dob = txtDate.Value.ToString("yyyy-MM-dd");

                DataHandler newPatient = new DataHandler();
                newPatient.AddUser(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtGender.Text, dob);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                txtName.Clear();
                txtSurname.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtGender.ResetText();
                txtDate.ResetText();

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            RegisteredUsers registered = new RegisteredUsers();
            registered.Show();
            this.Hide();
        }
    }
}
