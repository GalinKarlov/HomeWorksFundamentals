using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = " ";
            double price = 0.0;
            double price2 = 0.0;

            double discount = 0.0;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                price = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            

            if (package == "Normal")
            {
                price2 = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                price2 = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                price2 = 1000;
                discount = 0.15;
            }

            double totalPrice = price + price2;
            double discountPrice = totalPrice - totalPrice * discount;
            double pricePerPerson = discountPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                
                }
    }
}
