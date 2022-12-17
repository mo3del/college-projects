using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, first, last, sum;


            
            Console.Write("Input starting number of range: ");
            first = int.Parse(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            last = int.Parse(Console.ReadLine());

            Console.Write("The Perfect numbers between {0} and {1} are : \n", first, last);



            

            for (i = first; i <= last; i++)
            {
                sum = 0;

                

                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }



            Console.ReadKey();

        }
    }
}
