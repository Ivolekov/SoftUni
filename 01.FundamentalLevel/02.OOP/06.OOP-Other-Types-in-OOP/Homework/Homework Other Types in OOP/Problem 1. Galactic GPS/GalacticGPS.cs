﻿using System;

namespace Problem_1.Galactic_GPS
{
    class GalacticGPS
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
            Console.WriteLine();
        }
    }
}