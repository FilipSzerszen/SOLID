using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public class CardInserted : State
    {
        public CardInserted(Context context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Card ejected");
            // go to state InsertCard
        }

        public override void EnterPin(int pin)
        {
            if (pin == 8888) { 
                Console.WriteLine("Pin correct");
                _context.ChangeState(new PinEntered(_context));
            }
            else {
                Console.WriteLine("Pin incorrect, get a card");
                _context.ChangeState(new NoCard(_context));
            }

        }

        public override void InsertCard()
        {
            Console.WriteLine("Card already inserted");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Enter pin first");
        }
    }
}
