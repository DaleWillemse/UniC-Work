namespace listExercise
{
    public partial class ListExercise : Form
    {
        public ListExercise()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lstData.Clear();
            string[] lines = getData();

            foreach(string line in lines)
            {
                lstData.Items.Add(line);
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            lstSort.Clear();
            string[] lines = getData();
            List<int> numbers = new List<int>();

            foreach (string line in lines)
            {
                numbers.Add(int.Parse(line));
            }

            numbers.Sort();

            foreach(int number in numbers)
            {
                lstSort.Items.Add(number.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static string[] getData() 
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\data.txt";
            string[] lines = File.ReadAllLines(fileName);
            
            return lines;
        }

    }
}