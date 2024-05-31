using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class TrustAccount : SavingsAccount
    {
        public TrustAccount(string name = "Unnamed Account", double balance = 0, double interestRate = 0) : base(name, balance, interestRate)
        {
        }
        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
            {


                base.Deposit(amount);//should calc interst rate first
                    callBase(50);//add 50 then 
                return true;
            }

            else
                return base.Deposit(amount);
        }
        //public int HasThree(List<TrustAccount> accounts, int years)
        //{

        //}



    }
}