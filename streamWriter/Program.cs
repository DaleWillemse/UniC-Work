namespace streamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\text.txt";
            
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("This is academic year 2022");
                string text = "Welcome to Belgium Campus";

                writer.WriteLine(text);
                writer.Write("No more covid-19");
                writer.Write("...yeeahh");
            }

            Console.WriteLine("Successfully written to file.");
        }
    }
}