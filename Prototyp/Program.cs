using System;

namespace Prototyp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle()
            {
                X = 1,
                Y = 2,
                Radius = 3,
                border = new Border()
                {
                    Color = "red",
                    Size = "2px"
                }
            };
            Circle circle2 = (Circle)circle1.Clone();

            circle2.Radius = 5;

            Console.WriteLine(ReferenceEquals(circle1, circle2));
            Console.WriteLine(ReferenceEquals(circle1.border, circle2.border));
            Console.WriteLine($"{circle1.Radius}\r\n{circle2.Radius}");
        }
    }
}
