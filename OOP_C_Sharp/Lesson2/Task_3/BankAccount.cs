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
        private string _typeAccount = nameof(TypesAccount.расчетный);
        
        public BankAccount(decimal balanceAccount)
        {
            _balanceAccount = balanceAccount;
            CreateIdAccount();
        }

        public BankAccount(string typeAccount)
        {
            _typeAccount = typeAccount;
            CreateIdAccount();
        }

        public BankAccount(decimal balanceAccount, string typeAccount)
        {
            _balanceAccount = balanceAccount;
            _typeAccount = typeAccount;
            CreateIdAccount();
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
        private static int CreateIdAccount() => ++_idAccount;
    }
}
