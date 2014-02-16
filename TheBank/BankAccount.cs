using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    class BankAccount
    {
        public BankAccount(string owner)
        {
            m_owner = owner;
            m_balance = 0M;
        }

        protected string m_owner;
        virtual public string ID
        {
            get 
            { 
                return m_owner; 
            }
        }

        private decimal m_balance;
        public decimal Balance
        {
            get
            {
                return m_balance;
            }
        }

        public decimal Deposit(decimal amount)
        {
            m_balance += amount;
            return m_balance;
        }

        virtual public decimal Withdraw(decimal amount)
        {
            return (m_balance -= amount);
        }
    }
}
