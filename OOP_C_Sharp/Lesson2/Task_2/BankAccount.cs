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
        private string _typeAccount;
        public enum TypeAccount { расчетный, кредитный, сберегательный };

        /// <summary> Изменяет баланс счета </summary>
        /// <param name="value"></param>
        public void SetBalanceAccount(decimal value)
        {
            if (value >= 0)
            {
                _balanceAccount = value;
            }
        }

        /// <summary> Изменяет тип счета </summary>
        /// <param name="value"></param>
        public void SetTypeAccount(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _typeAccount = value;
            }
        }

        /// <summary> Возвращает номер счета </summary>
        /// <returns>номер счета</returns>
        public int GetIdAccount() => _idAccount;

        /// <summary> Возвращает баланс счета </summary>
        /// <returns>баланс счета</returns>
        public decimal GetBalanceAccount() => _balanceAccount;

        /// <summary> Возвращает тип счета </summary>
        /// <returns>тип счета</returns>
        public string GetTypeAccount() => _typeAccount;

        /// <summary> Создает уникальные номера счета </summary>
        /// <returns>уникальный номер счета</returns>
        public static int CreateIdAccount() => ++_idAccount;
    }
}
