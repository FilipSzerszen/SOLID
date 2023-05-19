using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace SOLID
{
    public class BankAccount
    {
        private float balance;
        private string name;
        public float Balance
        {
            get => balance;
            private set => balance = value;
        }

        public virtual void wypłać(float kasa) {
            if (kasa > 0) balance -= kasa;
        }

        public void wpłać(float kasa)
        {
            if (kasa > 0) balance += kasa;
        }
    }
}
