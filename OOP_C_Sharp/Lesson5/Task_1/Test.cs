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
            var fractionFirst = new Fraction(numerator: 1, denominator: 3);
            var fractionSecond = new Fraction(numerator: 2, denominator: 7);
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

            WriteLine($"{fractionFirst} == {number} : {fractionFirst == number}");
            WriteLine($"{number} == {fractionFirst} : {number == fractionFirst}");
            WriteLine($"{fractionFirst} == {fractionSecond} : {fractionFirst == fractionSecond}\n");

            WriteLine($"{fractionFirst} != {number} : {fractionFirst != number}");
            WriteLine($"{number} != {fractionFirst} : {number != fractionFirst}");
            WriteLine($"{fractionFirst} != {fractionSecond} : {fractionFirst != fractionSecond}\n");

            WriteLine($"++ {fractionFirst} = {++fractionFirst}");
            WriteLine($"-- {fractionSecond} = {--fractionSecond}");

            WriteLine();

            Fraction fractionF = (Fraction)5.5f;
            float y = fractionF;

            fractionF = (Fraction)8;
            int x = fractionF;
        }
    }
}
