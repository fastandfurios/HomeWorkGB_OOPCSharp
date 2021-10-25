using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_2
{
    internal sealed class BankAccount
    {
        private static int _idAccount;
        private decimal _balanceAccount;
        private int _number;
        private string _typeAccount;
        private enum TypeAccount { расчетный, кредитный, сберегательный };

        /// <summary> Меняет данные счета </summary>
        public void SetDataAccount(int balanceAccount, int number)
        {
            _balanceAccount = balanceAccount;
            _number = number;
            _typeAccount = Enumerable();
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
                ++i;
                if (i == _number)
                {
                    typeAcc = typeAccount;
                }
            }

            return typeAcc;
        }

        public static void Count() => ++_idAccount;
    }
}
