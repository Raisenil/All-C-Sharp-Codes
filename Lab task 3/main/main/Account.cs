using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        int amount;
        public Account()
        {
            accName="Niloy";
            acid="19399821";
            balance=5000;
        }

        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        public Account(string accName,string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("AccName : " + accName);
            Console.WriteLine("Acid : " + acid);
            Console.WriteLine("Balance : " + balance);
        }

        public void Deposit(int amount)
        {
            int balance1 = 0;
            balance1 = balance + amount;
            Console.WriteLine("New Balance after Deposit : " + balance1);
        }
        public void Withdraw(int amount)
        {
            int balance2 = 0;
            balance2 = balance - amount;
            Console.WriteLine("New Balance after Withdraw : " + balance2);
        }
    }
}
