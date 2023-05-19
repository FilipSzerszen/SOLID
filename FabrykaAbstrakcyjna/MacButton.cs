using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    public class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle mac button click");
        }

        public void Render()
        {
            Console.WriteLine("Render mac button");
        }
    }
}
