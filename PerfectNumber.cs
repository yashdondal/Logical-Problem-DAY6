﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    public class PerfectNumber
    {
        public static void CheckPerfectnumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find Perfect Number:");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter the starting number:");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number:");
            mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }

        }
    }
}

