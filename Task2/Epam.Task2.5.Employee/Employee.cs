using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Task2._3.User;



namespace Epam.Task2._5.Employee
{
    public class Employee : User
    {
        private string Firm { get; }
        private int WorkExperience { get; }
        private string Position { get; }

        public Employee()
        {
            Firm = InsertName("Enter the name of the employee's firm"); 
            WorkExperience = InsertValue("Enter the employee's work experience");
            Position = InsertName("Enter the name of employee's position");
        }
        
        
        private int InsertValue(string instruction)
        {
            Console.WriteLine(instruction);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) | (Age - value) < 18 | value < 0)
            {
                Console.WriteLine("You entered inappropriate number. Enter value again");
            }
            return value;
        }

        private string InsertName(string comment)
        {
            int i;
            string value;

            Console.WriteLine(comment);
            do
            {
                value = Console.ReadLine();
                value = value.Trim();
                bool checkdefice = false;
                for (i = 0; i < value.Length; i++)
                {
                    if (value[i] == '-' & checkdefice == false)
                    {
                        checkdefice = true;
                        continue;
                    }

                    if (char.IsLetterOrDigit(value[i]) | char.IsWhiteSpace(value[i]))
                    {
                        continue;
                    }
                    Console.WriteLine("Please, check your information");
                    break;
                }
            }
            while (i != value.Length);
            return value;
        }
        
        public override void Show()
        {
            Console.WriteLine($"Employee's name {Name}");
            Console.WriteLine($"Employee's birthdate {Birthday.ToShortDateString()}");
            Console.WriteLine($"Employee's age {Age}"); 
            Console.WriteLine($"Employee's work experience {WorkExperience}"); 
            Console.WriteLine($"Employee's position {Position}"); 
        }

    }

}
