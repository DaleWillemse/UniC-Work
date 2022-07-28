namespace ThreadingPractice
{
    class Program
    {
        static void Printing()
        {
            Console.WriteLine("How threads work.");
        }
        static void Printing2()
        {
            Console.WriteLine("The second thread works.");
        }
        static void Main(string[] args)
        {
            Thread x = new Thread(new ThreadStart(Program.Printing));
            x.Start();
            Thread.Sleep(3000); // Waits 3 seconds/ 3000 milliseconds
            Thread y = new Thread(new ThreadStart(Program.Printing2));
            y.Start();
        }
    }
}