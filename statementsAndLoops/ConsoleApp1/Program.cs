using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            string athlete = "Athlete";
            string businessman = "Businessman";
            string businesswoman = "Businesswoman";
            string softUniStudent = "SoftUni Student";
            

            if (profession == athlete)
            {
                Console.WriteLine("Water");
            }
            else if (profession == businessman || profession == businesswoman)
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == softUniStudent)

            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
