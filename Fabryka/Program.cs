using System;

namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            Shape circle = shapeFactory.CreateShape(ShapeType.Circle);
            Shape rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);

            circle.Render();
            rectangle.Render();
        }
    }
}
