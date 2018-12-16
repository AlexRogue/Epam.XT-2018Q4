using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5TointOrNotToInt
{
   public class ConcreteChecks
    {

        public static bool CheckDoubles(string str)
        {
            int echecker = 0;
            int dotchecker = 0;

            foreach (char cha in str)
            {
                if ((cha == 'E') | (cha == 'e'))
                {
                    echecker++;
                }

                if (cha == '.')
                {
                    dotchecker++;
                }
            }

            if (echecker > 1 | dotchecker > 1)
            {
                return false;
            }
            return true;
        }

        public static bool CheckDigit(string str)
        {
            foreach (char cha in str)
            {
                if (char.IsDigit(cha))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckAfterE(string str)
        {
            if (str.Length == 1 & (str.StartsWith("+") | str.StartsWith("-")))
            {
                return false;
            }

            if ((str.StartsWith("+") | str.StartsWith("-")) | char.IsDigit(str[0]))
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckLetter(string str)
        {
            foreach (char cha in str)
            {
                if (!char.IsDigit(cha))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckLetterandDot(string str)
        {
            foreach (char cha in str)
            {
                if (!char.IsDigit(cha) & cha != '.')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool FinalCheckMinus(string str1, string str2)
        {
            int i;
            int z;
            int str2toint = 0;
            int str1toint = 0;
            double finalcheck;

            for (i = str2.Length - 1, z = 0; i > 0; i--, z++)
            {
                str2toint = (str2[i] - 48) * ((int)Math.Pow(10, z) * -1);
            }

            for (i = str1.Length - 1, z = 0; i > 0; i--, z++)
            {
                str1toint = (str1[i] - 48) * ((int)Math.Pow(10, z));
            }

            finalcheck = str1toint * (Math.Pow(10, str2toint));
            if (finalcheck % 1 == 0)
            {
                Console.WriteLine("Number is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Number is not valid");
                return false;
            }
        }

        public static bool FinalCheckPlus(string str1, string str2)
        {
            int i;
            int z;
            int string2int = 0;
            int string1int = 0;
            double finalcheck;

            for (i = str2.Length - 1, z = 0; i > 0 | str2[i] != '+'; i--, z++)
            {
                string2int = (str2[i] - 48) * ((int)Math.Pow(10, z));
            }

            for (i = str1.Length - 1, z = 0; i > 0; i--, z++)
            {
                string1int = (str1[i] - 48) * ((int)Math.Pow(10, z));
            }

            finalcheck = string1int * (Math.Pow(10, string2int));
            if (finalcheck % 1 == 0)
            {
                Console.WriteLine("Number is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Number is not valid");
                return false;
            }
        }
    }
}

