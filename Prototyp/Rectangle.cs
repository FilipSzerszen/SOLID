using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp
{
    public class Rectangle : Shape
    {
        public override Shape Clone()
        {
            Console.WriteLine("Clone rectangle");

            var baseShape = (Rectangle)this.MemberwiseClone();
            baseShape.border = new Border()
            {
                Size = border.Size,
                Color = border.Color
            };
            return baseShape;
        }

        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }
    }
}
