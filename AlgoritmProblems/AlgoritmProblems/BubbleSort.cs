using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmProblems
{
    public class BubbleSort
    {
        /// <summary>
        /// Bubble() method to sort the given integer array(list of numbers)
        /// </summary>
        public static void Bubble()
        {
            int[] arr = { 70, 50, 80, 19, 7 };
            int temp;

            //sorting an array
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        //Swapping the numbers
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            //Print the Sorted array  
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
            Console.Write(p + " ");
            Console.Read();
        }
    }
}
