
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG182_Project_1
{
    class Program
    {
        enum Menu
        {
            CaptureDetails = 1,
            CheckCredit = 2,
            ShowStats = 3,
            Exit = 4
        }
        static void Main(string[] args)
        {
            List<string> applicants = new List<string>();
            List<string> qualifiedApplicants = new List<string>();
            string[] newapplicant = new string[7];
            bool qualified = false;
            bool exit = false;
            int countQualified = 0;
            int countNot = 0;
            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("1. Capture Details");
                Console.WriteLine("2. Check credit qualification");
                Console.WriteLine("3. Show qualification stats");
                Console.WriteLine("4. Exit the program.");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                Menu menu = new Menu();
                menu = (Menu)option;
                switch (option)
                {
                    case 1: // Adding more applicants.
                        bool leave = false;
                        while (leave == false)
                        {
                            Console.WriteLine("Do you want to add an applicant? \n\"Y\" - Yes\t \"N\" - No");
                            string temp = Console.ReadLine();
                            if (temp == "N" || temp == "n" || temp == "No" || temp == "no")
                            {
                                leave = true;
                            }
                            if (temp == "Y" || temp == "y" || temp == "Yes" || temp == "yes")
                            {
                                newapplicant = CaptureData(newapplicant);
                                foreach (var item in newapplicant)
                                {
                                    Console.WriteLine(item);
                                }
                                qualified = Qualify(int.Parse(newapplicant[2]), int.Parse(newapplicant[3]), int.Parse(newapplicant[4]), int.Parse(newapplicant[5]), int.Parse(newapplicant[6]));
                                if (qualified == true)
                                {
                                    qualifiedApplicants.AddRange(newapplicant);
                                    countQualified++;
                                }
                                else
                                {
                                    countNot++;
                                }
                                applicants.AddRange(newapplicant);
                            }
                        }
                        Console.Clear();
                        break;
                    case 2: // Displays all qualified applicants.
                        foreach (var item in qualifiedApplicants)
                        {
                            Console.Write(item);
                        }
                        Console.ReadKey();
                        break;
                    case 3: // Display amount qualified and amount not qualified.
                        Console.WriteLine($"{countQualified} has qualified. \n{ countNot}has not qualifed.");
                Console.ReadKey();
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
        }
        public static string[] CaptureData(string[] applicants)
        {
            Console.Clear();
            Console.WriteLine("Enter FullName:");
            applicants[0] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Are you currently employed? \n\"Y\" - Yes\t \"N\" - No");
            applicants[1] = Console.ReadLine();
            Console.Clear();
            if (applicants[1] == "No" || applicants[1] == "no" || applicants[1] == "N" || applicants[1] == "n")
            {
                applicants[2] = "0";
            }
            else
            {
                Console.WriteLine("How many years have you been with the current employer ? ");
               
                applicants[2] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("How many years have you lived at your current residence ? ");
           
            applicants[3] = Console.ReadLine();
            Console.Clear();

            if (applicants[1] == "No" || applicants[1] == "no" || applicants[1] == "N"
           || applicants[1] == "n")
            {
                applicants[4] = "0";
            }
            else
            {
                Console.WriteLine("Your monthly salary;");
                applicants[4] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Amount of non-mortgage debt:");
            applicants[5] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many children do you have?");
            applicants[6] = Console.ReadLine();
            Console.Clear();
            return applicants;
        }
        public static bool Qualify(int sameEmployer, int sameLocation, int salary, int debt, int kids)
        {
            bool qualified = false;

            if (sameEmployer >= 2)
            {
                if (sameLocation >= 2)
                {
                    if (salary * 2 > debt && kids < 6)
                    {
                        qualified = true;
                    }
                }
            }
            return qualified;
        }

    }
}