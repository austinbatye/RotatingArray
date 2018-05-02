using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingArray
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Input number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of cycles of array rotations: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements. Seperate each element with a space.");
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            ShiftedAll(a, k, n);

            foreach (int num in a)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine("");

        }

        public static int[] ShiftedAll(int[] a, int k, int n)
        {
            int swap;
            int counter = 0;
            int cycle = 1;
            while (counter < (k))
            {
                if (cycle % (n) != 0)
                {
                    swap = a[cycle - 1];
                    a[cycle - 1] = a[cycle];
                    a[cycle] = swap;
                    cycle += 1;
                }
                else
                {
                    cycle = 1;
                    counter += 1;
                }
            }

            return a;
        }
    }
}

