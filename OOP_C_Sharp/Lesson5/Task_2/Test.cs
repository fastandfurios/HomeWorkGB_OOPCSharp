using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Task_2
{
    public class Test
    {
        public void Run()
        {
            var complexNumber1 = new ComplexNumber(1, -1);
            var complexNumber2 = new ComplexNumber(3, 6);

            Console.WriteLine(complexNumber1 + complexNumber2);
            Console.WriteLine(complexNumber1 - complexNumber2);
            Console.WriteLine(complexNumber1 * complexNumber2);
            Console.WriteLine(complexNumber1 == complexNumber2);
            Console.WriteLine(complexNumber1 != complexNumber2);
        }
    }
}
