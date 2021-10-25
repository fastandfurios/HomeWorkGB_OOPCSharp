using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_3
{
    internal sealed class BankAccount
    {
        private static int _idAccount;
        private decimal _balanceAccount;
        private int _number;
        private string _typeAccount;
        public enum TypeAccount { расчетный, кредитный, сберегательный };

        public BankAccount(decimal balanceAccount)
        {
            _balanceAccount = balanceAccount;
            _typeAccount = nameof(TypeAccount.кредитный);
            Count();
        }

        public BankAccount(string typeAccount)
        {
            _balanceAccount = 5000;
            _typeAccount = typeAccount;
            Count();
        }

        public BankAccount(decimal balanceAccount, string typeAccount)
        {
            _balanceAccount = balanceAccount;
            _typeAccount = typeAccount;
            Count();
        }

        /// <summary> Читает данные счета </summary>
        public void ReadDataAccount()
        {
            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {_idAccount}\nБаланс счета: {_balanceAccount}\nТип счета: {_typeAccount}");
            Console.WriteLine();
        }

        /// <summary> Перечисляет типы счета </summary>
        private string Enumerable()
        {
            int i = 0;
            var typeAcc = string.Empty;

            foreach (var typeAccount in Enum.GetNames(typeof(TypeAccount)))
            {
                Console.WriteLine($"{++i} {typeAccount}");
                if (i == _number)
                {
                    typeAcc = typeAccount;
                }
            }

            return typeAcc;
        }

        private static int Count() => ++_idAccount;
    }
}
