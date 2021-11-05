using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson6.Task_1
{
    internal sealed class BankAccount
    {
        public int IdAccount { get; init; }

        private decimal _balanceAccount;
        public decimal BalanceAccount => _balanceAccount;

        private string _typeAccount;
        public string TypeAccount { get => _typeAccount; set => _typeAccount = value; }

        /// <summary> Переводит сумму на другой счет </summary>
        /// <param name="account">банковский счет</param>
        /// <param name="sum">сумма перевода</param>
        internal void Transfer(BankAccount account, decimal sum)
        {
            if (WithdrawAccount(sum))
            {
                account.DepositAccount(sum);
                Console.WriteLine($"Перевод на номер счета {account.IdAccount} выполнен успешно!");
            }
        }

        /// <summary> Пополняет банковский счет </summary>
        /// <param name="sum">сумма пополнения</param>
        internal void DepositAccount(decimal sum) => _balanceAccount += sum;

        /// <summary> Снимает с банковского счета </summary>
        /// <param name="sum">сумма снятия</param>
        /// <returns>результат о выполнении</returns>
        internal bool WithdrawAccount(decimal sum)
        {
            if (_balanceAccount - sum >= 0)
            {
                _balanceAccount -= sum;
                return true;
            }

            return false;
        }
    }
}
