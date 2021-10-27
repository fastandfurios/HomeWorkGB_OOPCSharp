using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson3.Task_1
{
    internal sealed class BankAccount
    {
        public int IdAccount { get; init; }

        private decimal _balanceAccount;
        public decimal BalanceAccount => _balanceAccount;

        private string _typeAccount;
        public string TypeAccount { get => _typeAccount; set => _typeAccount = value; }

        public void Transfer(BankAccount account, decimal sum)
        {
            if (WithdrawAccount(sum))
            {
                account.DepositAccount(sum);
                Console.WriteLine($"Перевод на номер счета {account.IdAccount} выполнен успешно!");
            }
        }

        public void DepositAccount(decimal balanceAccount) => _balanceAccount = balanceAccount;

        public bool WithdrawAccount(decimal balanceAccount)
        {
            if (_balanceAccount - balanceAccount >= 0)
            {
                _balanceAccount -= balanceAccount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
