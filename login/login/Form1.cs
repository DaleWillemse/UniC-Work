namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string dtUsername = "Dale";
        public static string dtPassword = "1234";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password", "Error");
            }
            else
            {
                if (dtUsername.Equals(txtUsername.Text) && dtPassword.Equals(txtPassword.Text))
                {
                    MessageBox.Show("Login Successful");
                    Admin admin = new Admin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    txtUsername.Focus();
                }
            }
        }
    }
}