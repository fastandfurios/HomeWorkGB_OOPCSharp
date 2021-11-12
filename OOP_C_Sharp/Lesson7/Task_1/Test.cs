using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public static class Test
    {
        public static void Run()
        {
            var bcoder = new ACoder();
            var entry = "Привет мир!";
            var encode = bcoder.Encode(new(entry, entry.Length), 3);
            bcoder.Decode(encode, 3);
        }
    }
}
