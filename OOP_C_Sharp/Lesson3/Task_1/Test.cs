using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson3.Task_1;

namespace Lesson3.Task_1
{
    internal sealed class Test
    {
        public void Run()
        {
            var account1 = new BankAccount { TypeAccount = nameof(TypesAccount.сберегательный) };
            
            Console.WriteLine("Счет успешно создан!");
            OutputChangedAccount(account1);

            Console.WriteLine();

            var account2 = new BankAccount { TypeAccount = nameof(TypesAccount.кредитный) };

            Console.WriteLine("Счет успешно создан!");
            OutputChangedAccount(account2);

            Console.WriteLine();

            account1.DepositAccount(500);

            Console.WriteLine("Счет пополнен!");
            OutputChangedAccount(account1);
            
            Console.WriteLine();

            account1.Transfer(account2, 50);

            Console.WriteLine();

            Console.WriteLine("Текущий статус счета: ");
            OutputChangedAccount(account1);

            Console.WriteLine();

            Console.WriteLine("Текущий статус счета: ");
            OutputChangedAccount(account2);
        }

        private void OutputChangedAccount(BankAccount account)
            => Console.WriteLine($"Номер счета: {account.IdAccount}\nБаланс счета: {account.BalanceAccount} ед.\nТип счета: {account.TypeAccount}");
    }
}
