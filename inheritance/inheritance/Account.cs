using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Account : Person
    {
        //Constructor
        public Account() { }
        public double getAccountBalance()
        {
            return currentAccount;
        }
        public double setAccountBalance(double amount)
        {
            currentAccount = currentAccount + amount;
            return currentAccount;
        }
        
        public double withdrawFromAccount(double amountToWithDraw)
        {
            currentAccount = currentAccount - amountToWithDraw;
            return currentAccount;
        }

        internal double getAccountBalance(double amountToWithDraw)
        {
            currentAccount = currentAccount - amountToWithDraw;
            return currentAccount;
        }
    }
}
