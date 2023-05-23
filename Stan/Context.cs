using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stan
{
    public class Context
    {
        private State _currentState;
        public int AvailableCash { get; set; } = 2000;

        public Context()
        {
            _currentState = new NoCard(this);
        }  

        public void ChangeState(State newState)
        {
            _currentState = newState;
        }
        
        public void InsertCard()
        {
            _currentState.InsertCard();
        }
        public void EjectCard()
        {
            _currentState.EjectCard();
        }
        public void EnterPin(int pin)
        {
            _currentState.EnterPin(pin);
        }
        public void EnterAmount(int amount)
        {
            _currentState.WithdrawCash(amount);
        }
    }
}
