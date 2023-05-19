using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjna
{
    public class MacTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle mac textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render mac textbox");
        }
    }
}
