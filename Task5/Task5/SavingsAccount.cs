using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
     public class SavingsAccount:Account
    {
        
        

        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0,  double interestRate = 0.0) :base(name, balance)
        {
            InterestRate = interestRate;
        }
    public double InterestRate { get; set; }



        public override bool Deposit(double amount)
        {
            amount = amount + (amount * InterestRate / 100);
          return  base.Deposit(amount);
        }

        public bool  callBase( double amount)
        {
           return base.Deposit(amount);
        }


    }
}

