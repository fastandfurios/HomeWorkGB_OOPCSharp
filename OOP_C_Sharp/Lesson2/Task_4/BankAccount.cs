using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_4
{
    internal sealed class BankAccount
    {
        private static int _idAccount;
        public static int IdAccount => CreateIdAccount();

        private decimal _balanceAccount;
        public decimal BalanceAccount { get => _balanceAccount; set => _balanceAccount = value; }

        private string _typeAccount;
        public string TypeAccount { get => _typeAccount; set => _typeAccount = value; }

        /// <summary> Создает уникальные номера счета </summary>
        /// <returns>уникальный номер счета</returns>
        private static int CreateIdAccount() => ++_idAccount;
    }
}
