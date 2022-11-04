namespace Willemse_Dale_PRG282_MockTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Employee> employeesToAdd = new List<Employee>();
        
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "" && txtName.Text != "" && txtSurname.Text != "")
            {
                lstEmployees.Items.Clear();
                string empID = txtId.Text;
                string name = txtName.Text;
                string surname = txtSurname.Text;
                employeesToAdd.Add(new Employee(empID, name, surname));
                foreach(Employee emp in employeesToAdd)
                {
                    lstEmployees.Items.Add(emp.EmpID + ", " + emp.Name + ", " + emp.Surname);
                }
                txtId.Clear();
                txtName.Clear();
                txtSurname.Clear();
            }
            else
            {
                MessageBox.Show("Please enter all details.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler.Write(employeesToAdd);
                MessageBox.Show("Data written to file successfully");
            }
            catch(IOException EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFormatted_Click(object sender, EventArgs e)
        {
            lstFormatted.Items.Clear();
            foreach(Employee emp in employeesToAdd)
            {
               string formatted = DataHandler.Format(emp.EmpID, emp.Name, emp.Surname);
                lstFormatted.Items.Add(formatted);
            }
        }
    }
}