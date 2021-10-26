using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_2
{
    internal sealed class Test
    {
        public void Run()
        {
            var account1 = new BankAccount();
            BankAccount.CreateIdAccount();
            account1.SetBalanceAccount(145);
            account1.SetTypeAccount(nameof(TypesAccount.расчетный));

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {account1.GetIdAccount()}\nБаланс счета: {account1.GetBalanceAccount()}\nТип счета: {account1.GetTypeAccount()}");

            Console.WriteLine();

            var account2 = new BankAccount();
            BankAccount.CreateIdAccount();
            account2.SetBalanceAccount(2134);
            account2.SetTypeAccount(nameof(TypesAccount.сберегательный));

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {account2.GetIdAccount()}\nБаланс счета: {account2.GetBalanceAccount()}\nТип счета: {account2.GetTypeAccount()}");

            Console.WriteLine();

            var account3 = new BankAccount();
            BankAccount.CreateIdAccount();
            account3.SetBalanceAccount(6847);
            account3.SetTypeAccount(nameof(TypesAccount.кредитный));

            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {account3.GetIdAccount()}\nБаланс счета: {account3.GetBalanceAccount()}\nТип счета: {account3.GetTypeAccount()}");
        }
    }
}
