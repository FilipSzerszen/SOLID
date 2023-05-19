using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PersonalBankAccount : BankAccount
    {
        public override void wypłać(float kasa)
        {
            base.wypłać(kasa);
        }
    }
}
