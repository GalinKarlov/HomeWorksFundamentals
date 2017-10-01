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

            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int combinations = 0;
            int sumOfNumbers = 0;
            for (int i = lastNumber; i >= firstNumber; i--)
            {
                for (int j = lastNumber; j >= firstNumber; j--)
                {
                    sumOfNumbers = i + j;
                    // Console.WriteLine(sumOfNumbers);
                    combinations++;
                    //Console.WriteLine(combinations);
                    if (sumOfNumbers == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
                        return;
                    }

                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");

        }
    }
}