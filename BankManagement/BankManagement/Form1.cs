namespace BankManagement
{
    public partial class Form1 : Form
    {

        int balance = 1000;
        int amount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBal.Text = balance.ToString();
        }

        // Button for adding cash to your current balance.
        private void btnDebit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                try
                {
                    amount = Convert.ToInt32(txtAmount.Text);
                    balance += amount;
                    txtBal.Text = balance.ToString();
                    lstLog.Text = amount.ToString();
                    lstLog.Items.Add(amount.ToString() + "\t\t" + balance.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter a numerical value.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an amount.");
            }
            txtAmount.Text = "";
        }

        // Button for removing cash from your current balance.
        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                try
                {
                    amount = Convert.ToInt32(txtAmount.Text);
                    balance -= amount;
                    txtBal.Text = balance.ToString();
                    lstLog.Items.Add(amount.ToString() + "\t\t" + balance.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter a numerical value.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an amount.");
            }
            txtAmount.Text = "";
        }
 
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            balance = 1000;
            amount = 0;
            lstLog.Items.Clear();
            lstLog.Items.Add("Amount" + "\t\t" + "Current Balance");
            txtBal.Text = balance.ToString();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtBal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

    }
}