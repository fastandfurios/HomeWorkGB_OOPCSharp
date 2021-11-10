﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson6.Task_1;
using static System.Console;

namespace Lesson6.Task_1
{
    internal sealed class Test
    {
        public static void Run()
        {
            var account1 = new BankAccount
            {
                TypeAccount = nameof(TypesAccount.savings)
            };

            WriteLine($"Счет успешно создан!\n{account1}");

            WriteLine();

            var account2 = new BankAccount
            {
                TypeAccount = nameof(TypesAccount.credit)
            };

            WriteLine($"Счет успешно создан!\n{account2}");

            WriteLine();

            account1.DepositAccount(500);

            WriteLine($"Счет пополнен!\n{account1}");
            
            WriteLine();

            account1.Transfer(account2, 50);

            WriteLine();

            WriteLine($"Текущий статус счета:\n{account1}");

            WriteLine();

            WriteLine($"Текущий статус счета:\n{account2}");

            WriteLine();

            WriteLine(account2 == account1);
            WriteLine(account1 != account2);
        }
    }
}
