using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());



            double priceForStudio = 0.0;
            double priceForDouble = 0.0;
            double priceForSuite = 0.0;



            double nightCountStudio = nightCount;

            double discount = 0.0;

            if (month == "May" || month == "October")
            {
                priceForStudio = 50;
                priceForDouble = 65;
                priceForSuite = 75;
                if (nightCount > 7)
                {
                    discount = 0.95;
                    priceForStudio = priceForStudio * discount;
                }
                if (month == "October" && nightCount > 7)
                {
                    nightCountStudio--;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceForStudio = 60;
                priceForDouble = 72;
                priceForSuite = 82;
                if (nightCount > 14)
                {
                    discount = 0.90;
                    priceForDouble = priceForDouble * discount;
                }
                if (month == "September" && nightCount > 7)
                {
                    nightCountStudio--;
                }
            }
            else if (month == "July"|| month == "August"|| month == "December")
            {
                priceForStudio = 68;
                priceForDouble = 77;
                priceForSuite = 89;
                if (nightCount > 14)
                {
                    discount = 0.85;
                    priceForSuite = priceForSuite * discount;
                }
            }
            double totalPriceStudio = priceForStudio * nightCountStudio;
            double totalPriceDouble = priceForDouble * nightCount;
            double totalPriceSuite = priceForSuite * nightCount;

            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:f2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:f2} lv.");

        }
    }
}
