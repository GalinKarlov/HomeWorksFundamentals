using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double EnergyPer100ml = energyContent / 100.0 * volume;
            double SugarContent100ml = sugarContent * volume / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{EnergyPer100ml}kcal, {SugarContent100ml}g sugars");
        }
    }
}
