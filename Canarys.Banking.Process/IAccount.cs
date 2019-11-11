using Canarys.Banking.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canarys.Banking.Process
{
    public interface IAccount
    {
        void Deposit(Double amount);
        void Withdraw(Double amount);
        //void FundTransfer (IAccount target,double amount)

        string ToString();
    }
    public static class AccountServer
    {
        public static IAccount Get(int id,string name,AccountType type,Double amount)
        {
            return Account.CreateNew(id, name, type, amount) as IAccount;
        }
    }
}
