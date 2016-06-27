using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjClassAbstract {
    class Program {
        static void Main(string[] args) {
            
            var testebase = new AuthorizationBaseRequest();
            var key = testebase.Transaction.TransactionKey;

        }
    }
}
