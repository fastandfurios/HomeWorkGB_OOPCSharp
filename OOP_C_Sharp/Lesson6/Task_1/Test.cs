using static System.Console;

namespace Lesson6.Task_1
{
    internal sealed class Test
    {
        public static void Run()
        {
            var account1 = new BankAccount
            {
                TypeAccount = TypesAccount.Savings.ToString(),
            };

            WriteLine($"Счет успешно создан!\n{account1}");

            WriteLine();

            var account2 = new BankAccount
            {
                TypeAccount = TypesAccount.Credit.ToString(),
            };

            WriteLine($"Счет успешно создан!\n{account2}");

            WriteLine();

            account1.DepositAccount(500);

            WriteLine($"Счет пополнен!\n{account1}");
            
            WriteLine();

            account1.TransferTo(account2, 50);

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
