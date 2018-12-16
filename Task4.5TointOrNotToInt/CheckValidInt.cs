using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._5TointOrNotToInt
{
    public static class CheckValidInt
    {        
        public static bool CheckInt(this string str)
        {
            int i = 0;
            List<String> splitArrayE;
            List<String> splitArrayDot;
                         
            if (!ConcreteChecks.CheckDoubles(str))
            {
                Console.WriteLine("Number is not valid");
                return false;
            }
            
            if (str.EndsWith("e") & str.StartsWith("+") | str.EndsWith("E") | char.IsDigit(str[i]))
            {
                splitArrayE = str.Split('E', 'e').ToList();
                splitArrayDot = splitArrayE[0].Split('.').ToList();
                if (!ConcreteChecks.CheckLetterandDot(splitArrayE[0]))
                {
                    Console.WriteLine("Number is not valid");
                    return false;
                }

                if (ConcreteChecks.CheckDigit(splitArrayE[0]) & (splitArrayE.Count > 1))   
                {
                    if (!ConcreteChecks.CheckAfterE(splitArrayE[1]) | splitArrayE[1].Contains('.'))
                    {
                        Console.WriteLine("Number is not valid");
                        return false;
                    }
                    if (splitArrayE[0].Contains('.')) 
                    {
                        if (!ConcreteChecks.CheckLetter(splitArrayDot[0]) | splitArrayDot[1].Length == 0)
                        {
                            Console.WriteLine("Number is not valid");
                            return false;
                        }

                        if (splitArrayE[1].StartsWith("-"))
                        {
                            return ConcreteChecks.FinalCheckMinus(splitArrayDot[0], splitArrayE[1]);
                        }
                        else
                        {
                            return ConcreteChecks.FinalCheckPlus(splitArrayDot[1], splitArrayE[1]);
                        }
                    }
                    else
                    {
                        if (splitArrayE[1].StartsWith("-"))
                        {
                            return ConcreteChecks.FinalCheckMinus(splitArrayE[0], splitArrayE[1]);
                        }
                        else
                        {
                            Console.WriteLine("Number is valid");
                            return true;
                        }   
                    }
                }
                else 
                {
                    if(splitArrayDot.Count > 1)
                    {
                        Console.WriteLine("Number is not valid");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Number is valid");
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Number is not valid");
                return false;
            }
        }
   }
}
