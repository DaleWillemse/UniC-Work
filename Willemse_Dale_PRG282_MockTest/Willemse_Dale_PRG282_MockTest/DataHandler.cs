using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Willemse_Dale_PRG282_MockTest
{
    class DataHandler
    {
        
        public static string Format(string id, string name, string surname)
        {
            Employee emp = new Employee(id, name, surname);
            return emp.ToString();
            
        }
    }
}
