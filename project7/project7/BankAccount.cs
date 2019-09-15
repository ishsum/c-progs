using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class BankAccount
    {
        int accountNumber;
        string accountHolderName;
        double Balance;
        public BankAccount(int acc,string hold,double bal)
        {
            accountNumber = acc;
            accountHolderName = hold;
            Balance = bal;
            //AccountTrans(ref new BankAccount ob());
        }
       public void AccountTransref(ref BankAccount ob)
        {
            ob.accountNumber = 2;
            ob.accountHolderName = "ishani gupta";
            ob.Balance = 500000;


        }
        public void AccountTrans(BankAccount ob1)
        {
            ob1.accountNumber = 22;
            ob1.accountHolderName = "ishani gupta2";
            ob1.Balance = 5000002;

        }
        public void Display()
        {
            Console.WriteLine(accountNumber);
            Console.WriteLine(accountHolderName);
            Console.WriteLine(Balance);



        }
    }
}
