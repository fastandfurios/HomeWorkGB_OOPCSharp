using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson5.Task_1
{
    public class Test
    {
        public void Run()
        {
            var fractionFirst = new Fraction(1, 3);
            var fractionSecond = new Fraction(2, 7);
            var number = 4;
            WriteLine($"{fractionFirst} + {number} = {fractionFirst + number}");
            WriteLine($"{number} + {fractionFirst} = {number + fractionFirst}");
            WriteLine($"{fractionFirst} + {fractionSecond} = {fractionFirst + fractionSecond}\n");

            WriteLine($"{fractionFirst} - {number} = {fractionFirst - number}");
            WriteLine($"{number} - {fractionFirst} = {number - fractionFirst}");
            WriteLine($"{fractionFirst} - {fractionSecond} = {fractionFirst - fractionSecond}\n");
            
            WriteLine($"{fractionFirst} * {number} = {fractionFirst * number}");
            WriteLine($"{number} * {fractionFirst} = {number * fractionFirst}");
            WriteLine($"{fractionFirst} * {fractionSecond} = {fractionFirst * fractionSecond}\n");

            WriteLine($"{fractionFirst} / {number} = {fractionFirst / number}");
            WriteLine($"{number} / {fractionFirst} = {number / fractionFirst}");
            WriteLine($"{fractionFirst} / {fractionSecond} = {fractionFirst / fractionSecond}\n");

            WriteLine($"{fractionFirst} % {number} = {fractionFirst % number}");
            WriteLine($"{number} % {fractionFirst} = {number % fractionFirst}");
            WriteLine($"{fractionFirst} % {fractionSecond} = {fractionFirst % fractionSecond}\n");

            WriteLine($"{fractionFirst} > {number} : {fractionFirst > number}");
            WriteLine($"{number} > {fractionFirst} : {number > fractionFirst}");
            WriteLine($"{fractionFirst} > {fractionSecond} : {fractionFirst > fractionSecond}\n");

            WriteLine($"{fractionFirst} >= {number} : {fractionFirst >= number}");
            WriteLine($"{number} >= {fractionFirst} : {number >= fractionFirst}");
            WriteLine($"{fractionFirst} >= {fractionSecond} : {fractionFirst >= fractionSecond}\n");

            WriteLine($"{fractionFirst} < {number} : {fractionFirst < number}");
            WriteLine($"{number} < {fractionFirst} : {number < fractionFirst}");
            WriteLine($"{fractionFirst} < {fractionSecond} : {fractionFirst < fractionSecond}\n");

            WriteLine($"{fractionFirst} <= {number} : {fractionFirst <= number}");
            WriteLine($"{number} <= {fractionFirst} : {number <= fractionFirst}");
            WriteLine($"{fractionFirst} <= {fractionSecond} : {fractionFirst <= fractionSecond}\n");

            WriteLine($"++ {fractionFirst} = {++fractionFirst}");
            WriteLine($"-- {fractionSecond} = {--fractionSecond}");
        }
    }
}
