using System.Text;

namespace Lesson7.Task_1
{
    public class BCoder : ICoder
    {
        /// <summary> Декодирует закодированную строку, меняя местами начальные символы с конечными символами </summary>
        /// <param name="entry">входящая строка</param>
        /// <param name="depht">глубина кодирования (n-символов, помененных местами)</param>
        /// <returns>раскодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо длина строки была меньше пары символов, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Decode(StringBuilder entry)
        {
            if (!entry.IsNullOrWiteSpace())
            {
                //for (int i = 0; i < depht; i++)
                //{
                //    if(depht != entry.Length - 1 - depht && entry[depht] != entry[entry.Length - 1 - depht])
                //    {
                //        var symbol = entry[entry.Length - 1 - i];
                //        entry[entry.Length - 1 - i] = entry[i];
                //        entry[i] = symbol;
                //    }
                //}

                return entry;
            }

            throw new ArgumentException("Строка не может быть раскодирована!");
        }

        /// <summary> Кодирует строку, меняя местами начальные символы с конечными символами </summary>
        /// <param name="entry">входящая строка</param>
        /// <param name="depht">глубина кодирования (n-символов, помененных местами)</param>
        /// <returns>закодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо длина строки была меньше пары символов, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Encode(StringBuilder entry)
        {
            if(!entry.IsNullOrWiteSpace())
            {
                //for (int i = 0; i < depht; i++)
                //{
                //    if(depht != entry.Length - 1 - depht && entry[depht] != entry[entry.Length - 1 - depht])
                //    {
                //        var symbol = entry[i];
                //        entry[i] = entry[entry.Length - 1 - i];
                //        entry[entry.Length - 1 - i] = symbol;
                //    }
                //}

                return entry;
            }

            throw new ArgumentException("Строка не может быть закодирована!");
        }
    }
}
