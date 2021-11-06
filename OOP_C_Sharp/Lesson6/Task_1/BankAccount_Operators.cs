using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_1
{
    internal sealed partial class BankAccount : IEquatable<BankAccount>
    {
        public static bool operator ==(BankAccount a, BankAccount b)
            => a.IdAccount == b.IdAccount && 
               a._balanceAccount == b._balanceAccount &&
               a._typeAccount == b._typeAccount;

        public static bool operator !=(BankAccount a, BankAccount b)
            => a.IdAccount != b.IdAccount &&
               a._balanceAccount != b._balanceAccount &&
               a._typeAccount != b._typeAccount;

        public override bool Equals(object obj) => Equals(obj as BankAccount);

        public bool Equals(BankAccount other)
        {
            if (other is null) return false;
            return IdAccount == other.IdAccount
                   && _balanceAccount == other._balanceAccount
                   && _typeAccount == other._typeAccount;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = _idAccount.GetHashCode();
                hash = (hash * 404) ^ _typeAccount.GetHashCode();
                return hash;
            }
        }
    }
}
