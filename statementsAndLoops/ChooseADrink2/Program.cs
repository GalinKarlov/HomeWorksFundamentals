using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int cuantities = int.Parse(Console.ReadLine());

            double waterPrice = 0.70;
            double coffeePrice = 1.00;
            double beerPrice = 1.70;
            double teaPrice = 1.20;

            string athlete = "Athlete";
            string businessman = "Businessman";
            string businesswoman = "Businesswoman";
            string softUniStudent = "SoftUni Student";

            double totalPrice = 0.0;

            if (profession == athlete)
            {
                totalPrice = waterPrice * cuantities;
                
            }
            else if (profession == businessman || profession == businesswoman)
            {
                totalPrice = coffeePrice * cuantities;
            }
            else if (profession == softUniStudent)

            {
                totalPrice = cuantities * beerPrice;
            }
            else
            {
                totalPrice = teaPrice * cuantities;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");

        }
    }
}
