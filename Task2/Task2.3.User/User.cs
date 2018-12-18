using System;
using System.Globalization;

namespace Task2._3.User
{
    public class User 
    {
        protected int Age { get; }
        protected DateTime Birthday { get; }
        protected string Name { get; }


        public User()
        {   
          Birthday = BirthdayCalculation("Enter user's birthday");
          Name = InsertName("Enter user's name");
          Age = CalculateAgeCorrect(Birthday, DateTime.Now);
        }


        private int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            var age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;
            Console.WriteLine($"User's age {age}");
            return age;
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

                    if (char.IsLetter(value[i]) | char.IsWhiteSpace(value[i]))
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


        private DateTime BirthdayCalculation(string comment)
        {
                     Console.WriteLine(comment);
                     bool check = false;
                     DateTime result = new DateTime();
                     do
                     {
                         if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy",
                             null, DateTimeStyles.None, out result))
                         {
                             Console.WriteLine("Reenter your birthdate! You should use blueprint dd.MM.yyyy");
                             check = true;
                             continue;

                         }

                         if (((DateTime.Today.Year - result.Year) > 150) || ((DateTime.Today.Year - result.Year) < 0))
                         {
                             Console.WriteLine("Reenter your birthdate! It doesn't exist");
                             check = true;
                             continue;
                         }

                         check = false;
                     } while (check);
                     return result;
        }


        public virtual void Show()
        {
            Console.WriteLine($"User's name {Name}");
            Console.WriteLine($"User's birthdate {Birthday.ToShortDateString()}");
            Console.WriteLine($"User's age {Age}"); 
        }
    }

  
}