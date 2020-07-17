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
            //Intermediate Difficulty
           {
               int m, i, sum = 0, avg = 0;
               Console.WriteLine("Enter the total number of scores (0-100) you will be inputting: ");

               m = int.Parse(Console.ReadLine());
               int[] a = new int[m];
               Console.WriteLine("Now, Enter the grades (0-100) below, the results will display when complete: ");

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
               double gradePer = sum / m;
               string gradeLetter = "F";

                if (gradePer >= 60 && gradePer < 70)
                {
                    gradeLetter = "D";
                    Console.WriteLine("They may need to request tutoring or extra credit!");
                }
                else if (gradePer >= 70 && gradePer < 80)
                {
                    gradeLetter = "C";
                    Console.WriteLine("The grade C is still passing but they may need to study a little more!");
                }
                else if (gradePer >= 80 && gradePer < 90)
                {
                    gradeLetter = "B";
                    Console.WriteLine("B for Brazo Zulu!!");
                }
                else if (gradePer >= 90 && gradePer <= 100)
                {
                    gradeLetter = "A";
                    Console.WriteLine("Good Job Superstar!");
                }


                Console.WriteLine("\nThe Letter Grade is: " + gradeLetter);


            }

        }
    }
}
