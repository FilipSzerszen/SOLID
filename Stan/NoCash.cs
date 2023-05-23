using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public class NoCash : State
    {
        public NoCash(Context context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("This cashmachine is empty");
           
        }

        public override void EnterPin(int pin)
        {
            Console.WriteLine("This cashmachine is empty");
        }

        public override void InsertCard()
        {
            Console.WriteLine("This cashmachine is empty");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("This cashmachine is empty");
        }
    }
}
