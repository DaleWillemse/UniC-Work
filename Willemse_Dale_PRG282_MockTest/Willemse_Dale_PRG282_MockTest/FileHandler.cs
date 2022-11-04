using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Willemse_Dale_PRG282_MockTest
{
    class FileHandler
    {
        
        public static List<Employee> Read()
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\employeeInfo.txt";

            List<Employee> employees = new List<Employee>();
            
            try
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream); 
                string line;
                
                while((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(",");
                    employees.Add(new Employee(data[0], data[1], data[2]));
                }
                reader.Close();
                stream.Close();
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message);
            }
            return employees;
        }
        
        public static void Write(List<Employee> employees)
        {
            string fileName = @"C:\Users\DaleWillemse\Desktop\employeeInfo.txt";
            File.WriteAllText(fileName, string.Empty);
            
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            using (writer)
            {
                foreach(Employee emp in employees)
                {
                    writer.WriteLine("{0}, {1}, {2}", emp.EmpID, emp.Name, emp.Surname);
                }
            }

        }
    }
}
