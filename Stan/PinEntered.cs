using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public class PinEntered : State
    {
        public PinEntered(Context context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context));
        }

        public override void EnterPin(int pin)
        {
            Console.WriteLine("Pin already entered");
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card already inserted");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Enter amout to withdraw");
            if (amount > 0 && amount <= _context.AvailableCash)
            {
                Console.WriteLine("Get a cash");
                _context.AvailableCash -= amount;

                if (_context.AvailableCash == 0)
                {
                    _context.ChangeState(new NoCash(_context));
                }
                else
                {
                    _context.ChangeState(new NoCard(_context));
                }

            }
            else
            {
                Console.WriteLine("Type correct amount");
            }

        }
    }
    
}
