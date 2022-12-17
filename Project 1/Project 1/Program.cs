using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            int num, i, m, first, last;

            
            Console.Write("Input First number : ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Input Last number : ");
            last = int.Parse(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", first, last);


             

            for (num = first; num <= last; num++)
            {
                m = 0;

                

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        m++;
                        break;
                    }
                }

                if (m == 0 && num != 1)
                    Console.WriteLine(num);
            }



            Console.ReadLine();
        }
    }
}
