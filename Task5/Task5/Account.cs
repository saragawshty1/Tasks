using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Account
    {
        public string name;
        public double balance;

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double GetBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return $"[Account: {name}: {balance}]";
        }
        public static Account operator +(Account lhs,Account rhs)
        {
            Account acc = new Account() {name=lhs.name+rhs.name,balance=lhs.balance+rhs.balance };
            return acc ;
        }
    }
}
