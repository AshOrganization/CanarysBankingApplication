using Canarys.Banking.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canarys.Banking.Entities
{
  public   class AccountInfo
    {
        #region

        private int _id;
        private string _name;
        private AccountType _type;
        private double _balance;

        #endregion

        #region Properties
        public int Id { get { return _id; } set { _id = value; } }
        public AccountType Type { get { return _type; } set { _type = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double Balance { get { return _balance; } set { _balance = value; } }
        #endregion


        #region Constructor
        public AccountInfo(int id,string name,AccountType type, double amount)
        {
            _id = id;_name = name;_type = type;_balance = amount;
        }


        //This hides the constructor from being accessible to the outer world
        private AccountInfo() { }
        #endregion
    }
}
