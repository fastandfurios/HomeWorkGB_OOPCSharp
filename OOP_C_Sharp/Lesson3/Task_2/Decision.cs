using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Task_2
{
    internal sealed class Decision
    {
        internal string FlipLetters(string entry)
        {
            var temp = string.Empty; 

            for (int i = entry.Length - 1; i >= 0; i--)
            {
                temp += entry[i];
            }

            return temp;
        }
    }
}
