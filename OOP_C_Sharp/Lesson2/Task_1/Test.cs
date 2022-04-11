using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_1
{
    internal sealed class Test
    {
        public void Run()
        {
            var account1 = new BankAccount();
            account1.SetIdAccount(1);
            account1.SetBalanceAccount(145);
            account1.SetTypeAccount(nameof(TypesAccount.расчетный));

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {account1.GetIdAccount()}\nБаланс счета: {account1.GetBalanceAccount()}\nТип счета: {account1.GetTypeAccount()}");

            Console.WriteLine();

            var account2 = new BankAccount();
            account2.SetIdAccount(2);
            account2.SetBalanceAccount(2134);
            account2.SetTypeAccount(nameof(TypesAccount.сберегательный));

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {account2.GetIdAccount()}\nБаланс счета: {account2.GetBalanceAccount()}\nТип счета: {account2.GetTypeAccount()}");
        }
    }
}
