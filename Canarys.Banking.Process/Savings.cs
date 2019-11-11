using Canarys.Banking.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canarys.Banking.Process
{
    internal class Savings:Account
    {
        public Savings(int id, string name, AccountType type, double amount):base(id,name,type,amount)
        {
            
        }
        public override void Withdraw(Double amount)
        {
            if (_info.Balance - amount > 499)
                _info.Balance -= amount;
            else
            throw new MinimumBalanceException("Insufficioent Funds") { DateTime=DateTime.Now};
        }
    }
}
