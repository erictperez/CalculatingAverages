using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Difficulty
            {
                int m, i, sum = 0, avg = 0;
                Console.WriteLine("Enter the number 10 for how many inputs: ");

                m = int.Parse(Console.ReadLine());
                int[] a = new int[m];
                Console.WriteLine("Now, Enter the numbers (0-100) below, the results will display when complete: ");

                for (i = 0; i < m; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (i = 0; i < m; i++)
                {
                    sum += a[i];
                }
                avg = sum / m;
                Console.WriteLine("Sum is {0}", sum);
                Console.WriteLine("Average is {0}", avg);
            }

        }
    }
}
