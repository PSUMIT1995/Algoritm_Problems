using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmProblems
{
    public class PrimeNumber
    {
        /// <summary>
        /// Prime() Prints the Prime numbers from 0 to 1000
        /// </summary>
        public static void Prime()
        {
            Console.WriteLine("Prime Number From O to 1000");
            for (int number = 1; number <= 1000; number++)
            {
                int count = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }

            }
        }
    }

}
