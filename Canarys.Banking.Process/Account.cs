using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canarys.Banking.Entities;
using Canarys.Banking.Shared;

namespace Canarys.Banking.Process
{
    internal abstract class Account:IAccount
    {

        protected AccountInfo _info;
       

        #region Constructors
        public Account(int id,string name,AccountType type,double amount)
        {
            _info = new AccountInfo(id, name, type, amount);
        }
        public Account(AccountInfo info) { _info = info; }

        #endregion


        #region methods

        public void Deposit(double amount) { _info.Balance += amount; }

        public abstract void Withdraw(double amount); //{

            /* if (_info.Type == AccountType.Savings && (_info.Balance - amount) > 499)
                 _info.Balance -= amount;
             else 
            if (_info.Type == AccountType.Current && (_info.Balance - amount) > 2499)
                _info.Balance -= amount;
                */
         //   else { }
        //}


        public void FundTransfer(Account target,double amount)
        {
            target.Deposit(amount);
            this.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"ID:{_info.Id},Name:{_info.Name},Type:{_info.Type},Balance:{_info.Balance}";
        }
        #endregion

        internal static Account CreateNew(int id,string name,AccountType type,double amount)
        {
            Account acc = null;
            if (type == AccountType.Savings && amount > 500)
                acc = new Savings(id, name, type, amount);   //bc=dc
            if (type == AccountType.Current && amount > 4999)
                acc = new Current(id, name, type, amount);

            return acc;
        }

        ~Account()
        {
            _info = null;
        
        }
    }
}
