using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_3
{
    internal sealed class TestInputData
    {
        public void Run()
        {
            var account1 = new BankAccount(1000);
            account1.ReadDataAccount();

            var account2 = new BankAccount(nameof(BankAccount.TypeAccount.сберегательный));
            account2.ReadDataAccount();

            var account3 = new BankAccount(4340, nameof(BankAccount.TypeAccount.расчетный));
            account3.ReadDataAccount();
        }
    }
}
