using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    class Program
    {
        //Luis Sanchez - Assignment 4 - 28/07/2017
        //300796405
        //Inheritance - Ch.10 | worth 10%
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116.464, 5.6836, "Ice");
            Console.WriteLine(giantPlanet);
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972,true);
            Console.WriteLine(terrestrialPlanet);
            Console.ReadLine();
        }
    }
}
