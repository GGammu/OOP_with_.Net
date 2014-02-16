using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    class CheckingAccount : BankAccount
    {
        private string m_owner;
        public CheckingAccount(string owner)
        {
            m_owner = owner;
        }

        private int m_checks = 0;
        public override decimal Withdraw(decimal amount)
        {
            m_checks++;
            return (base.Withdraw(amount + 0.25M));
        }

        public override string PrintStatement()
        {
            string statement = string.Format("{0}\n" + "Opening balance: $0.00\nDeposits: {1:C}\nWithdrawals: {2:C}\n" +
                "Interest: {3:C}\nChecking charges: {4:C}\n", new object[] {this.ID, this.TotalDeposits,
                this.TotalWithrawals - (m_checks * 0.25M), this.m_checks * 0.25D, this.Balance});
            return statement;
        }

        public override string ID
        {
            get { return m_owner + "-C"; }
        }
    }
}
