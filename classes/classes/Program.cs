namespace classes
{
    internal class Program
    {
        public delegate bool checkMethod(string[] data, string name);

        static void Main(string[] args)
        {
            
            string[] data = {"Llewelyn", "Miguel", "Juanro", "Comfort", "Dale"};
            
            string name = " Dale ";
            
            checkMethod check = new checkMethod(search);
            
            if (check.Invoke(data, name.Trim())) // trim removes all spaces.
            {
                Console.WriteLine("Name found.");
            }
            else
            {
                Console.WriteLine("Name not found.");
                
            }
            
            Student student = new Student("Dale", 21, 123456);
            student.displayInfo();
        }
        
        public static bool search(string[] data, string name)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}