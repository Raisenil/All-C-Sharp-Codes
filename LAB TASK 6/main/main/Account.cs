using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Account
    {
        string accName;
        string acid;
        int balance=5000;

        public string AccName 
        { 
            get { return accName; } 
            set { accName = value; }
        }
        public string AcId 
        { 
            get { return acid; } 
            set { acid = value; } 
        }
        public int Balance 
        { 
            get { return balance; } 
            set { balance = value; } 
        }

        public Account()
        {

        }
        public Account(string accName,string acId,int balance)
        {
            this.accName = accName;
            this.acid = acId;
            this.balance = balance;
        }

        public void showInfo()
        {
            Console.WriteLine("Account Name : " + accName);
            Console.WriteLine("Account ID : " + acid);
            Console.WriteLine("Balance : " + balance);
        }
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("New Balance after Deposit : " + balance);
        }
        public void Withdraw(int amount)
        {
            if (balance > amount)
            {
                balance = balance - amount;
                Console.WriteLine("Blanance after Withdraw : " + balance);
            }
            else
            {
                Console.WriteLine("Amount extends Balance");
            }
        }
        public void Transfer(int amount,Account receiver)
        {
            if(balance>amount)
            {
                if(receiver !=null)
                {
                    receiver.balance += amount;
                    this.balance -= amount;
                }
            }
            else
            {
                Console.WriteLine("Amount extends Balance");
            }
        }
    }
}
