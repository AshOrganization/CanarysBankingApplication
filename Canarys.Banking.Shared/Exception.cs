using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canarys.Banking.Shared
{

    [Serializable]
    public class MinimumBalanceException
        : System.Exception
    {
        public DateTime DateTime { get; set; }
        public MinimumBalanceException() { }
        public MinimumBalanceException(string message) : base(message) { }
        public MinimumBalanceException(string message, System.Exception inner) : base(message, inner) { }
        protected MinimumBalanceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
