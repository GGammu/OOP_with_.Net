using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABetterBank
{
    class SavingAccount : BankAccount
    {
        private string m_owner;

        public SavingAccount(string owner)
        {
            m_owner = owner;
        }

        private decimal m_interest = 0.01M;
        public decimal Interest
        {
            get { return m_interest; }
            set { m_interest = value; }
        }

        private decimal m_totalInterest = 0M;
        public decimal AddInterest()
        {
            decimal interest = m_interest * this.Balance;
            m_totalInterest = interest;
            this.Deposit(interest);
            return this.Balance;
        }

        public override string PrintStatement()
        {
            string statement = string.Format("{0}\n" + "Opening balance: $0.00\nDeposits: {1:C}\nWithdrawals: {2:C}\n" +
                "Interest: {3:C}\nEnding balbace: {4:C}\n", new object[] {this.ID, this.TotalDeposits - m_totalInterest,
                this.TotalWithrawals, this.m_totalInterest, this.Balance});
            return statement;
        }

        public override string ID
        {
            get { return m_owner + "-S"; }
        }

        //public static void Main()
        //{
        //    SavingAccount saving = new SavingAccount("Young");
        //    Console.WriteLine( saving.PrintStatement());
        //}
    }
}
