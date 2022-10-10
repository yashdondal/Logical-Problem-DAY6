using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemDay6
{
    internal class CouponCode
    {
        public static void DistinctCouponNumber()
        {
            int[] arr = new int[10];
            int[] Distinct = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }

                }
                if (count == 1)
                {
                    Distinct[i] = arr[i];
                }

            }
            foreach (int i in Distinct)
            {
                if (i != 0)
                {
                    Console.Write(i);
                }
            }
        }
    }
}