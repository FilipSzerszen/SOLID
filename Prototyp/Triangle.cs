using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototyp
{
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }
        public override Shape Clone()
        {
            Console.WriteLine("Clone triangle");

            var baseShape = (Triangle)this.MemberwiseClone();
            baseShape.border = new Border()
            {
                Size = border.Size,
                Color = border.Color
            };
            return baseShape;
        }
    }
}
