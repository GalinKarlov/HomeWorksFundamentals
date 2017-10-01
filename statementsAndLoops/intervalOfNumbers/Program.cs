using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            if (startNumber < endNumber)
            {
                while (startNumber <= endNumber)
                {
                    Console.WriteLine(startNumber);
                    startNumber++;

                }
            }
            else if (endNumber < startNumber) {
                while (endNumber <= startNumber)
                {
                    Console.WriteLine(endNumber);
                    endNumber++;

                }
            }

        }
        }
    }

