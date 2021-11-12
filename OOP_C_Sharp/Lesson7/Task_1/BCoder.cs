using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public class BCoder : ICoder
    {
        public StringBuilder Decode(StringBuilder entry, int depht)
        {
            //TODO: переделать логику в методе
            if (depht != entry.Length - 1 - depht &&
                entry[depht] != entry[entry.Length - 1 - depht] &&
                entry != null &&
                entry.Length > 1)
            {
                var symbol = entry[entry.Length - 1 - depht];
                entry[entry.Length - 1 - depht] = entry[depht];
                entry[depht] = symbol;
                return entry;
            }

            throw new ArgumentException("Строка не может быть раскодирована!");
        }

        public StringBuilder Encode(StringBuilder entry, int depht)
        {
            //TODO: протестить метод
            if(entry != null && entry.Length > 1)
            {
                for (int i = 0; i < depht; i++)
                {
                    if(depht != entry.Length - 1 - depht && entry[depht] != entry[entry.Length - 1 - depht])
                    {
                        var symbol = entry[i];
                        entry[i] = entry[entry.Length - 1 - i];
                        entry[entry.Length - 1 - i] = symbol;
                    }
                }

                return entry;
            }

            throw new ArgumentException("Строка не может быть закодирована!");
        }
    }
}
