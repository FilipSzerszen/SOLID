using System;

namespace Stan
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.EjectCard();

            context.InsertCard();
            context.EnterPin(8888);
            context.EnterAmount(2000);

            context.InsertCard();
            context.EnterPin(8888);

            
        }
    }
}
