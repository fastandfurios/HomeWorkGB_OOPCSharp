using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public class BCoder : ICoder
    {
        public StringBuilder Decode(StringBuilder entry, int index)
        {
            if (index != entry.Length - 1 - index && entry[index] != entry[entry.Length - 1 - index])
            {
                var symbol = entry[entry.Length - 1 - index];
                entry[entry.Length - 1 - index] = entry[index];
                entry[index] = symbol;
                return entry;
            }

            return entry;
        }

        public StringBuilder Encode(StringBuilder entry, int index)
        {
            if(index != entry.Length - 1 - index && entry[index] != entry[entry.Length - 1 - index])
            {
                var symbol = entry[index];
                entry[index] = entry[entry.Length - 1 - index];
                entry[entry.Length - 1 - index] = symbol;
                return entry;
            }

            return entry;
        }
    }
}
