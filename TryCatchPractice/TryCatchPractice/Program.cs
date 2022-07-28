namespace TryCatchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(x/y);
            }
            catch(DivideByZeroException) // Different exceptions within the brackets.
            {
                Console.WriteLine("Error devide by zero");
            }
            catch
            {
                Console.WriteLine("DONT DO THAT");
            }
            finally // Will execute no matter the outcome.
            {
                Console.WriteLine("Finally");
            }
        }
    }
}