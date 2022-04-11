using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_4
{
    internal sealed class Test
    {
        public void Run()
        {
            var account1 = new BankAccount();
            account1.BalanceAccount = 4583;
            account1.TypeAccount = nameof(TypesAccount.расчетный);

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {BankAccount.IdAccount}\nБаланс счета: {account1.BalanceAccount}\nТип счета: {account1.TypeAccount}");

            Console.WriteLine();

            var account2 = new BankAccount();
            account2.BalanceAccount = 875;
            account2.TypeAccount = nameof(TypesAccount.сберегательный);

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {BankAccount.IdAccount}\nБаланс счета: {account2.BalanceAccount}\nТип счета: {account2.TypeAccount}");

            Console.WriteLine();

            var account3 = new BankAccount();
            account3.BalanceAccount = 100002;
            account3.TypeAccount = nameof(TypesAccount.кредитный);

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {BankAccount.IdAccount}\nБаланс счета: {account3.BalanceAccount}\nТип счета: {account3.TypeAccount}");
        }
    }
}
