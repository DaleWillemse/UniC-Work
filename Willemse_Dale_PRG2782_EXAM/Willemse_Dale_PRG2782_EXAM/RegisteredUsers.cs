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
    public partial class RegisteredUsers : Form
    {
        public RegisteredUsers()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * FROM tblRegistration";
                DataHandler displayUsers = new DataHandler();
                DataTable dt = displayUsers.DisplayUsers(query);
                dgvDisplay.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"SELECT * FROM tblRegistration WHERE Email = '{txtEmailSearch.Text}' ";
                DataHandler displayUser = new DataHandler();
                DataTable dt = displayUser.DisplayUsers(query);
                dgvDisplay.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtEmailSearch.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"DELETE FROM tblRegistration WHERE Email = '{txtEmailSearch.Text}' ";
                DataHandler deleteUser = new DataHandler();
                deleteUser.DeleteUser(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtEmailSearch.Clear();

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e) // button for going back to sign up page.
        {
            Form1 signUp = new Form1();
            signUp.Show();
            this.Hide();
        }
    }
}
