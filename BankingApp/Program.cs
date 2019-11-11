using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canarys.Banking.Process;
using Canarys.Banking.Shared;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Account acc = Account.CreateNew(101, "Sample", AccountType.Savings, 1000);
            IAccount acc = AccountServer.Get(101, "Sample", AccountType.Savings, 1000);
            if(acc==null)
            {
                Console.WriteLine("Error creating account object.Terminating code");
            }
            Console.WriteLine($"1.{acc}");
            acc.Deposit(5000);
            Console.WriteLine($"2.Deposited 5000, \n\t{acc}");
            try
            {
                acc.Withdraw(2500);
            }
            catch (MinimumBalanceException me)
            {
                Console.WriteLine(me.Message );
            }
            Console.WriteLine($"3.Withdrew 4500, \n\t{acc}");
            //create another account
           // Account acc2 = Account.CreateNew(102, "Jumble", AccountType.Current, 5000);
            IAccount acc2 = AccountServer.Get(101, "Sample", AccountType.Savings, 1500);
            if (acc2 == null)
            {
                Console.WriteLine("Error creating account object.Terminating code");
            }
            Console.WriteLine($"4.Another account, \n\t{acc2}");
            //acc.FundTransfer(acc2, 1000);
            Console.WriteLine($"5.After fund transfer:, \n\t{acc}\n\t{acc2}");
            Console.WriteLine("".PadLeft(45,'-'));


        }
    }
}
