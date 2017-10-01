using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int combination = 0;
            int combinationSum = 0;
            int count = 0;
            for (int i = firstLine; i >= 1; i--)
            {
                for (int j = 1; j <= secondLine; j++)
                {
                    //combination++;
                    combinationSum = (i * j);



                    if (combination >= maxSum)
                    {
                        break;

                    }
                    combination = combination + 3 * combinationSum;

                    count++;
                }
            }
            if (combination >= maxSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {combination} >= {maxSum}");

            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {combination}");
            }

        }
    }
}