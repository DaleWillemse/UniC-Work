using System.IO;

namespace fileReadingWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\test.txt";

            string txt;

            int delete;
            
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Dispose();
                    Console.WriteLine("Enter text to go into document.");
                    txt = Console.ReadLine();
                    using (TextWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine(txt);
                    }

                Console.WriteLine("File created successfully.");
                }
                else
                {
                    Console.WriteLine("File already exists.");
                    Console.WriteLine("Do you want to delete the file?");
                    Console.WriteLine("1 - Yes,  0 - No");
                    delete = int.Parse(Console.ReadLine());
                    if (delete == 1)
                    {
                        File.Delete(fileName);
                        Console.WriteLine("File successfully deleted.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("File could not be created.");
            }
        }
    }
}