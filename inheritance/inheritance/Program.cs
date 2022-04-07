using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account class
            Account myAccount = new Account();
            double currentAmount = 0.0;
            //save money in current account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("current amount : {0}", currentAmount);

            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine("current amount : {0}", currentAmount);

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("current amount : {0}", currentAmount);
            Console.ReadLine();

        }
    }
}
