using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson2.Task_Star
{
    internal sealed class BankAccount
    {
        public int IdAccount { get; init; }

        private decimal _balanceAccount;
        public decimal BalanceAccount => _balanceAccount;

        private string _typeAccount;
        public string TypeAccount { get => _typeAccount; set => _typeAccount = value; }

        public void DepositAccount(decimal balanceAccount)
        {
            Console.WriteLine("Счет успешно пополнен! Текущий статус счета:");
            _balanceAccount = balanceAccount;
        }

        public void WithdrawAccount(decimal balanceAccount)
        {
            if (_balanceAccount - balanceAccount >= 0)
            {
                Console.WriteLine("Снятие со счета! Текущий статус счета:");
                _balanceAccount -= balanceAccount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счету!");
            }
        }
    }
}
