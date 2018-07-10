using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int rupee = int.Parse(Console.ReadLine());
            if(rupee % 10 == 0 || rupee % 10 == 5)
            {
                CalculateDenominations(rupee);
            }
        }

        public static void CalculateDenominations(int rupee)
        {
            int count = 0;
            if (rupee >= 500)
            {
                count = rupee / 500;
                Console.WriteLine($"500 * {count}");
                CalculateDenominations(rupee % 500);
            }
            else if (rupee >= 100 && rupee < 500)
            {
                count = rupee / 100;
                Console.WriteLine($"100 * {count}");
                CalculateDenominations(rupee % 100);
            }
            else if (rupee >= 50 && rupee < 100)
            {
                count = rupee / 50;
                Console.WriteLine($"50 * {count}");
                CalculateDenominations(rupee % 50);
            }
            else if (rupee >= 10 && rupee < 50)
            {
                count = rupee / 10;
                Console.WriteLine($"10 * {count}");
                CalculateDenominations(rupee % 10);
            }
            else if (rupee >= 5 && rupee < 10)
            {
                count = rupee / 5;
                Console.WriteLine($"5 * {count}");
                CalculateDenominations(rupee % 5);
            }
            
        }
    }
}
