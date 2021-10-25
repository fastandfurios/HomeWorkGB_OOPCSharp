using System;
using Lesson2.Task_1;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new BankAccount();
            bank.SetDataAccount();
            bank.ReadDataAccount();
        }
    }
}
