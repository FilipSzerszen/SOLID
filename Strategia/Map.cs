using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    public class Map
    {
        private IRoutestrategy _routestrategy;
        public Map(IRoutestrategy routestrategy)
        {
            _routestrategy = routestrategy;
        }
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            _routestrategy.CreateRoute(start, end);
        }
    }
}
