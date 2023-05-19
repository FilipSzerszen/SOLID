using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override Shape Clone()
        {
            Console.WriteLine("Clone circle");
            var baseShape = (Circle)this.MemberwiseClone();
            baseShape.border = new Border()
            {
                Size = border.Size,
                Color = border.Color
            };
            return baseShape;
        }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
