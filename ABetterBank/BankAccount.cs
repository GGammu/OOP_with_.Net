using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    abstract class BankAccount
    {
        private decimal m_balance;
        public decimal Balance
        {
            get { return m_balance; }
        }

        private decimal m_totalDeposits;
        public decimal TotalDeposits
        {
            get { return m_totalDeposits; }
        }

        private decimal m_totalWithdrawals;
        public decimal TotalWithrawals
        {
            get { return m_totalWithdrawals; }
        }

        public decimal Deposit(decimal amount)
        {
            m_totalDeposits += amount;
            return m_balance += amount;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            m_totalWithdrawals += amount;
            return m_balance -= amount;
        }

        public abstract string ID { get; }

        public abstract string PrintStatement();
    }
}
