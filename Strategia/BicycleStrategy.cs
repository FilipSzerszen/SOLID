﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    public class BicycleStrategy : IRoutestrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Bicycle strategy");
        }
    }
}
