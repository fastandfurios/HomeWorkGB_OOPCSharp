using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Task_2
{
    internal sealed class TestInputData
    {
        public void Run()
        {
            var bankAcc = new BankAccount();
            BankAccount.Count();
            bankAcc.SetDataAccount(100, 1);
            bankAcc.ReadDataAccount();

            var bankAcc1 = new BankAccount();
            BankAccount.Count();
            bankAcc1.SetDataAccount(3400, 3);
            bankAcc1.ReadDataAccount();
        }
    }
}
