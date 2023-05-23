using System;

namespace Strategia
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new BicycleStrategy();
            var map = new Map(strategy);

            Coordinate start = new Coordinate { Lat = 12.3, Long = 17.9 };
            Coordinate end = new Coordinate { Lat = 16.3, Long = 11.9 };

            map.CreateRoute(start, end);
        }
    }
}
