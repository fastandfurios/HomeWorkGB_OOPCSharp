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

        /// <summary> Пополняет счет </summary>
        /// <param name="sum">сумма пополнения</param>
        public void DepositAccount(decimal sum)
        {
            Console.WriteLine("Счет успешно пополнен! Текущий статус счета:");
            _balanceAccount += sum;
        }

        /// <summary> Снимает со счета </summary>
        /// <param name="sum">сумма снятия</param>
        public void WithdrawAccount(decimal sum)
        {
            if (_balanceAccount - sum >= 0)
            {
                Console.WriteLine("Снятие со счета! Текущий статус счета:");
                _balanceAccount -= sum;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счету!");
            }
        }
    }
}
