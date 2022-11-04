using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willemse_Dale_PRG282_MockTest
{
    internal class Employee
    {
        private string empID;
        private string name;
        private string surname;

        public Employee(string empID, string name, string surname)
        {
            this.empID = empID;
            this.name = name;
            this.surname = surname;
        }

        public string EmpID { get => empID; set => empID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public override string ToString()
        {
            return string.Format("EmployeeID: {0}| Name: {1}| Surname: {2}", EmpID, Name, Surname);
        }
    }
}
