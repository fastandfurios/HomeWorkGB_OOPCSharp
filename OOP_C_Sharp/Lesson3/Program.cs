using System;
using System.Threading.Tasks;
using Lesson3.Task_1;
using Lesson3.Task_2;
using Test_Star = Lesson3.Task_Star.Test;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //var test = new Test();
            //test.Run();

            //Задача 2
            //var decision = new Decision();
            //Console.WriteLine(decision.FlipLetters("Привет мир!"));

            //Задача со звездочкой
            var test = new Test_Star();
            test.Run();
        }
    }
}
