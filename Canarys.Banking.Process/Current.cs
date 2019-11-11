using Canarys.Banking.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canarys.Banking.Process
{

   internal class Current:Account
    {
        public Current(int id, string name, AccountType type, double amount):base(id,name,type,amount)
        {

        }

        public override void Withdraw(double amount)
        {
           
            if ((_info.Balance - amount) > 2499)
                _info.Balance -= amount;
            else
                throw new MinimumBalanceException("Insufficioent Funds") { DateTime = DateTime.Now };
        }


    }
}
