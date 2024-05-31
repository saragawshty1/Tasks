using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0) : base(name, balance)
        {
        }
        

        public override bool Withdraw(double amount)
        {
            const double fee = 1.50;
            amount = amount + fee;
            return base.Withdraw(amount);
        }



    }
}
