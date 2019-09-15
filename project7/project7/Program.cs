using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project7
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BankAccount obj1 = new BankAccount(1,"Ishani",1200000.034);
            obj1.Display();
            obj1.AccountTrans(obj1);
            obj1.Display();
            obj1.AccountTransref(ref obj1);
            obj1.Display();
        }


    }
}
