using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_Star
{
    internal sealed class Test
    {
        public void Run()
        {
            var account1 = new BankAccount { IdAccount = 1 };
            account1.TypeAccount = nameof(TypesAccount.расчетный);

            Console.WriteLine("Счет успешно создан!");
            OutputChangedAccount(account1);

            Console.WriteLine();

            account1.DepositAccount(100);
            OutputChangedAccount(account1);

            Console.WriteLine();

            account1.WithdrawAccount(50);
            OutputChangedAccount(account1);

            Console.WriteLine();

            account1.WithdrawAccount(100);
            OutputChangedAccount(account1);
        }

        private void OutputChangedAccount(BankAccount account)
            => Console.WriteLine($"Номер счета: {account.IdAccount}\nБаланс счета: {account.BalanceAccount} ед.\nТип счета: {account.TypeAccount}");
    }
}
