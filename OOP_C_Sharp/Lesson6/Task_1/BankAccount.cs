using System;

namespace Lesson6.Task_1
{
    internal sealed partial class BankAccount
    {
        private static int _idAccount; 
        private decimal _balanceAccount;
        private string _typeAccount;

        private static int GenerateId() => ++_idAccount;
        public int IdAccount { get; }
        public string TypeAccount { init => _typeAccount = value; }

        public BankAccount() => IdAccount = GenerateId();

        public override string ToString()
            => $"Номер счета: {IdAccount}\nБаланс счета: {_balanceAccount} ед.\nТип счета: {_typeAccount}";

        /// <summary> Переводит сумму на другой счет </summary>
        /// <param name="account">банковский счет</param>
        /// <param name="sum">сумма перевода</param>
        internal void TransferTo(BankAccount account, decimal sum)
        {
            if (Withdrawal.WithdrawAccount(sum, _balanceAccount, out _balanceAccount))
            {
                account.DepositAccount(sum);
                Console.WriteLine($"Перевод на номер счета {account.IdAccount} выполнен успешно!");
            }
        }

        /// <summary> Пополняет банковский счет </summary>
        /// <param name="sum">сумма пополнения</param>
        internal void DepositAccount(decimal sum) => _balanceAccount += sum;

    }
}
