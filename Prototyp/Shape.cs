using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Border border { get; set; }
        public abstract void Render();
        public abstract Shape Clone();
    }
}
