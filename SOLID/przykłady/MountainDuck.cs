using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class MountainDuck: Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Mountain duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Mountain duck swim");
        }

        public override void Fly()
        {
            Console.WriteLine("Mountain duck flies");
        }
    }
}
