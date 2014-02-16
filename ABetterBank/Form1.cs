using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABetterBank
{
    public partial class Form1 : Form
    {
        private CheckingAccount checking = new CheckingAccount("Young");
        private SavingAccount saving = new SavingAccount("Young");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BankAccount account = new BankAccount("Robin");
            //account.Deposit(25M);
            //MessageBox.Show(string.Format("{0:C}", account.Balance));

            //SavingAccount savings = new SavingAccount("Young");
            //savings.Deposit(150M);
            //savings.Withdraw(50M);
            //savings.Interest = 0.05M;
            //savings.AddInterest();
            //MessageBox.Show(string.Format("{0}: {1:C}", savings.ID, savings.Balance));

            //CheckingAccount checking = new CheckingAccount("Young");
            //checking.Deposit(50M);
            //checking.Withdraw(5M);
            //MessageBox.Show(string.Format("{0}: {1}", checking.ID, checking.Balance));

            //BankAccount account;
            //account = new CheckingAccount("Young");
            //account.Deposit(25M);
            //account.Withdraw(5M);
            //MessageBox.Show(string.Format("{0}: {1}", account.ID, account.Balance));

            this.account.Items.Add(checking);
            this.account.Items.Add(saving);
            this.account.SelectedIndex = 0;
            this.action.SelectedIndex = 0;
            this.amount.Text = "100";
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            BankAccount selectedAccount;
            //object item = this.account.SelectedItem;
            //selectedAccount = (BankAccount)item;
            selectedAccount = (BankAccount)this.account.SelectedItem;
            switch (action.Text)
            {
                case "Deposit":
                    selectedAccount.Deposit(decimal.Parse(amount.Text));
                    break;
                case "Withdraw":
                    selectedAccount.Withdraw(decimal.Parse(amount.Text));
                    break;
            }
            MessageBox.Show(string.Format("{0}: {1}", selectedAccount.ID, selectedAccount.Balance));
        }

        private void account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (account.SelectedItem is SavingAccount)
            {
                addInterest.Visible = true;
            }
            else
            {
                addInterest.Visible = false;
            }
        }

        private void addInterest_Click(object sender, EventArgs e)
        {
            SavingAccount theSavings = (SavingAccount)account.SelectedItem;
            //SavingAccount theSavings = account.SelectedItem as SavingAccount;
            if (theSavings != null)
            {
                theSavings.AddInterest();
                MessageBox.Show(string.Format("{0}: {1}", theSavings.ID, theSavings.Balance));
            }
        }

        private void printStatement_Click(object sender, EventArgs e)
        {
            BankAccount selectedAccount;
            object item = account.SelectedItem;
            selectedAccount = (BankAccount)item;
            MessageBox.Show(selectedAccount.PrintStatement());
        }
    }
}
