using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_1
{
    internal sealed partial class BankAccount
    {
        public static bool operator ==(BankAccount a, BankAccount b)
            => a!.IdAccount.Equals(b!.IdAccount) && 
               a._balanceAccount.Equals(b._balanceAccount) &&
               a._typeAccount.Equals(b._typeAccount);

        public static bool operator !=(BankAccount a, BankAccount b)
            => !(a!.IdAccount.Equals(b!.IdAccount) &&
               a._balanceAccount.Equals(b._balanceAccount) &&
               a._typeAccount.Equals(b._typeAccount));

        public override bool Equals(object obj) 
            => obj!.ToString() == ToString();

        public override int GetHashCode() 
            => ToString()!.GetHashCode();
    }
}
