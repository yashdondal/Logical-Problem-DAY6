using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    internal class ReverseNumber
    {
        public static void findReverseNumber()
        {
            int n;
            int reverse = 0;
            int rem;
            Console.WriteLine("Please enter the number-");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {

                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse No is {0}", reverse);
        }
    }
}
