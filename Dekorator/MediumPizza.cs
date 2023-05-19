using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    public class MediumPizza :IPizza
    {
        public double CalculatePrice()
        {
            return 20;
        }
    }
}
