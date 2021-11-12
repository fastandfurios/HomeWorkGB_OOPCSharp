using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public class ACoder : ICoder
    {
        public StringBuilder Decode(StringBuilder entry, int lenghtShift)
        {
            for (int i = 0; i < lenghtShift; i++)
            {
                entry = entry.Insert(0, entry[entry.Length - 1].ToString(), 1);
                entry = entry.Remove(entry.Length - 1, 1);
            }

            return entry;
        }

        public StringBuilder Encode(StringBuilder entry, int lenghtShift)
        {
            for (int i = 0; i < lenghtShift; i++)
            {
                entry = entry.Append(entry[0]);
                entry = entry.Remove(0, 1);
            }

            return entry;
        }
    }
}
