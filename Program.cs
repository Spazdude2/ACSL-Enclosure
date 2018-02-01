using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSL_Enclosure
{
    class Program
    {
        static void Main(string[] args)
        {  
            string equation;           
            string op = "+-*/";
            string braces = "{[()]}";
            string nums = "0123456789";

            string a;

            Console.WriteLine("Enter an expression with a missing symbol of enclosure.");
            equation = Console.ReadLine();

            int[] pos = new int[equation.Length];

            foreach (char c in equation)
            {
                if (braces.Substring(0,1).Contains(c) && !braces.Substring(5, 1).Contains(c))
                {
                    if (braces.Substring(4,1).Contains(c))
                    {
                        pos[0] = equation.Length;
                    }
                    a = equation.Insert(pos[0], braces.Substring(5, 1));
                    Console.Write(a);
                }
            }
            
        }
    }
}
