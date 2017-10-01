using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int c = 0;

            for (int n1 = numberOne; n1 <= numberTwo; n1++)
            {
                for (int n2 = numberOne; n2 <= numberTwo; n2++)
                {
                    for (int n3 = numberOne; n3 <= numberTwo; n3++)
                    {
                        for (int n4 = numberOne; n4 <= numberTwo; n4++)
                        {
                            for (int n5 = numberOne; n5 <= numberTwo; n5++)
                            {
                                if (numberOne <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= numberTwo)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    c++;
                                }
                            }
                        }
                    }
                }
            }
            if (c == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
