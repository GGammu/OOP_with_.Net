using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    class CheckingAccount : ABetterBank.BankAccount
    {
        public CheckingAccount(string owner)
            : base(owner)
        {

        }

        public override string ID
        {
            get
            {
                return base.ID + "-C";
            }
        }

        public override decimal Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(0.25M);
            return this.Balance;
        }

    }
}
