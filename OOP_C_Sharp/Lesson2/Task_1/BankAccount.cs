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
        private string _typeAccount;
        public enum TypeAccount { расчетный, кредитный, сберегательный };

        /// <summary> Изменяет номер счета </summary>
        /// <param name="value"></param>
        public void SetIdAccount(int value)
        {
            if (value > 0)
            {
                _idAccount = value;
            }
        }

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
    }
}
