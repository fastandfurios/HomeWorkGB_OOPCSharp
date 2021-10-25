using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_1
{
    internal sealed class BankAccount
    {
        private int _idAccount;
        private decimal _balanceAccount;
        private int _number;
        private string _typeAccount;
        private enum TypeAccount { расчетный, кредитный, сберегательный };

        /// <summary> Меняет данные счета </summary>
        public void SetDataAccount()
        {
            try
            {
                Console.Write("Номер счета: ");
                _idAccount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Баланс счета: ");
                _balanceAccount = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Выберите счет:");
                Enumerable();
                _number = Convert.ToInt32(Console.ReadLine());
                _typeAccount = Enumerable();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary> Читает данные счета </summary>
        public void ReadDataAccount()
        {
            Console.Clear();
            Console.WriteLine("Счет успешно создан!");
            Console.WriteLine($"Номер счета: {_idAccount}\nБаланс счета: {_balanceAccount}\nТип счета: {_typeAccount}");
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
    }
}
