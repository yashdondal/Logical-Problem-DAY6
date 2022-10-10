using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    internal class PrimeNumber
    {
        static int count = 0;
        public static void CheckprimeNumber()
        {
            Console.WriteLine("Check Whether the given number is prime or not");

            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("The Number is prime", num);
            }
            else
            {
                Console.WriteLine("The Given Number is not prime");
            }
        }
    }
}
