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
            var acoder = new ACoder();
            var entry = "Привет мир!";
            var encode = acoder.Encode(new(entry, entry.Length), 3);
            acoder.Decode(encode, 3);
            var bcoder = new BCoder();
            var encode_1 = bcoder.Encode(new(entry, entry.Length), 0);
            bcoder.Decode(encode_1, 0);
        }
    }
}
