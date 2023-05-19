using System;

namespace FabrykaAbstrakcyjna
{
    class Program
    {
        static void Main(string[] args)
        {
            var uiApplication = new Application(new MacFactory());
            uiApplication.RenderUI();
        }
    }
}
