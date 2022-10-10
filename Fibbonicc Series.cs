using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    public static class FibonacciSeries
    {
        static int n1 = 0;
        static int n2 = 1;
        static int n3;
        static int i;

        public static void DisplayFibonacciSeries()
        {


            Console.WriteLine("Enter the number to print FibonacciSeries");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + " " + n2);

            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                Console.ReadLine();
            }
        }

    }
}
    

