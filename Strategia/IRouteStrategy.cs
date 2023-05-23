using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategia
{
    public interface IRoutestrategy
    {
        void CreateRoute(Coordinate start, Coordinate end);
    }
}
