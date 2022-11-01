namespace readFromTextFile
{
    internal class program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\infor.txt";

            readInfo(fileName);
        }

        public static void readInfo(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            
            Console.WriteLine("Formatted Data\n================================================");
            foreach(string line in lines)
            {
                string[] data = line.Split(',');
                Console.WriteLine("First Name: {0}| Last Name: {1}| Job: {2}", data[0], data[1], data[2]);
            }
            Console.WriteLine("==================================================");
        }
    }
}