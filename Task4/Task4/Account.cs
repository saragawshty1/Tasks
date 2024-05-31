using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public  class Account
    {
        public Account(string name="none", decimal startingBalance=0)
        {
           Name = name;
           balance = startingBalance;
        }

       // public string Name  { get { return Name; } }  if read only
       private string Name { get; set; }
        private  decimal balance { get; set; }


        public  bool Deposit(decimal amoutToAdd)
        {
            if (amoutToAdd > 0)
            {
                balance += amoutToAdd;
                return true;
            }
            else
                return false;
        }

        public bool withdraw (decimal amountToSub) 
        {
            if (amountToSub > 0 && amountToSub < balance)
            {
                balance -= amountToSub;
                return true;
            }
             
            else
                return false;
         }
        public void print()
        {
            Console.WriteLine($"Name : {Name} and balance : {balance}");
        }
        public  override string ToString()
        {
            return $"[Account:{Name}:{balance}]";
        }
        
}}
