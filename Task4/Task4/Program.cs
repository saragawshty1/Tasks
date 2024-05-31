namespace Task4

{
    enum MenuOption
    {
        withdraw = 0,
        Deposit = 1,
        print = 2,
        quit = 3
    }
    

    internal class Program
    {
        public static MenuOption ReadUserOption()
        {
            int input = 0;

            do
            {
                Console.WriteLine("Enter the option you need");
                Console.WriteLine("-------------------------");
                Console.WriteLine("0 - Withdraw");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Print");
                Console.WriteLine("3 - Quit");
                input = int.Parse(Console.ReadLine());
            } while (input < 0 || input > 3);
            return (MenuOption)input;

        }
     
    //--------------------------------------------------------------
     private static void DoDeposit(Account accountt)
    {
        Console.WriteLine("enter the amount you need to add please");
        decimal amoutToAdd = decimal.Parse(Console.ReadLine());
            if (accountt.Deposit(amoutToAdd))
                Console.WriteLine(accountt);
            else
                Console.WriteLine("the amount is invalid");
        
    }
        public static void Dowithdraw(Account account)

        {
            Console.WriteLine("enter the amount please");
            decimal amountToSub = decimal.Parse(Console.ReadLine());
           if( account.withdraw(amountToSub))
                Console.WriteLine(account);
           else
                Console.WriteLine("the amount is invalid");

        }

           public static void Doprint(Account account)
            {
                account.print();
            }


            static void Main(string[] args)
        {

            //Account account = new Account("jakes Account", 2000);
            //account.print();
            //account.Deposit(100);
            //account.print();
            Account account1 = new Account("sara mohamed", 5000);
            //account1.print();
            //account1.Deposit(300);
            //account1.print();
            //account1.withdraw(200);
            //account1.print();
            switch (ReadUserOption())
            {
                case MenuOption.Deposit:
                    DoDeposit(account1);
                    
                    break;
                case MenuOption.withdraw:
                    Dowithdraw(account1);
                    
                    break;
            
                case MenuOption.print:
                     Doprint(account1);
                    break;
                case MenuOption.quit:
                    Console.WriteLine("Good bye");
                    break;
                
            }
        }
   
    }



}
