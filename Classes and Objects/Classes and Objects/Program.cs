using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, gender;
            int age;

            List<Person> MyPersonList = new List<Person>();

            bool exit = false;

            while(exit == false)
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("Please enter your surname:");
                surname = Console.ReadLine();
                Console.WriteLine("Please enter your gender:");
                gender = Console.ReadLine();
                Console.WriteLine("Please enter your age:");
                age = int.Parse(Console.ReadLine());

                Person MyPerson = new Person(name, surname, gender, age);

                MyPersonList.Add(MyPerson);

                Console.WriteLine("Do you want to add another person?");
                if(Console.ReadLine() == "n")
                {
                    exit = true;
                }
            }
            Console.Clear();
            foreach(var item in MyPersonList)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.Name, item.Surname, item.Gender, item.Age);
            }
            Console.ReadLine();
        }

    }

}