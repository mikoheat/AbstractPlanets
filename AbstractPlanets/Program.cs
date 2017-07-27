using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The Author's name: Taeho Kim
/// Author’s  student number: 300914207
/// Date last Modified: 2017/07/24
/// Program description: Program class which has main method.
/// Revision History: 2017/07/24 - Make a method named WaitForAnyKey.
/// </summary>
namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Made by Taeho Kim");
            Console.WriteLine("Student number: 300914207");
            Console.WriteLine();
            Console.WriteLine();
            GiantPlanet GiantPlanet = new GiantPlanet("GiantPlanet", 5000000, 95000000, "IcE");
            TerrestrialPlanet TerrestrialPlanet = new TerrestrialPlanet("TerrestrialPlanet", 15168, 6749, true);

            Console.WriteLine("=============================================");
            Console.WriteLine(GiantPlanet.ToString());
            Console.WriteLine("=============================================");

            Console.WriteLine();

            Console.WriteLine("=============================================");
            Console.WriteLine(TerrestrialPlanet.ToString());
            Console.WriteLine("=============================================");

            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to terminate a program.");
        }
    }
}
