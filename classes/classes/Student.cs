using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Student
    {

        private string name;
        private int age;
        private int id;
        
        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            Console.WriteLine("\nStudent created!");
            
        }

        public void displayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Id: " + id);
        }
    }
}
