using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    class SavingAccount : ABetterBank.BankAccount
    {
        public SavingAccount(string owner) : base(owner)           
        {
            Console.WriteLine("this");
        }

        public override string ID
        {
            get
            {
                return this.m_owner + "-S";
            }
        }

        private decimal m_interest = 0.01M;
        public decimal Interest
        {
            get
            {
                return m_interest;
            }
            set
            {
                m_interest = value;
            }
        }

        public decimal AddInterest()
        {
            this.Deposit(m_interest * this.Balance);
            return this.Balance;
        }
    }
}
