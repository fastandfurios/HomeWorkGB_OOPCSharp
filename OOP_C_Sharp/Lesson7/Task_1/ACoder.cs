using System.Text;

namespace Lesson7.Task_1
{
    public class ACoder : ICoder
    {
        /// <summary> Декодирует закодированную строку, смещая ее на n-символов вправо </summary>
        /// <param name="entry">входящая строка</param>
        /// <param name="dephtShift">глубина кодирования (n-символов строки, которые необходимо сместить)</param>
        /// <returns>раскодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо длина строки была меньше пары символов, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Decode(StringBuilder entry, int dephtShift)
        {
            if(!entry.IsNullOrWiteSpace() && entry.Length > 1)
            {
                for (int i = 0; i < dephtShift; i++)
                {
                    entry = entry.Insert(0, entry[^1].ToString(), 1);
                    entry = entry.Remove(entry.Length - 1, 1);
                }

                return entry;
            }

            throw new ArgumentException("Строка не может быть раскодирована!");
        }

        /// <summary> Кодирует строку, смещая ее на n-символов влево </summary>
        /// <param name="entry">входящая строка</param>
        /// <param name="dephtShift">глубина кодирования (n-символов строки, которые необходимо сместить)</param>
        /// <returns>закодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо длина строки была меньше пары символов, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Encode(StringBuilder entry, int dephtShift)
        {
            if (!entry.IsNullOrWiteSpace() && entry.Length > 1)
            {
                for (int i = 0; i < dephtShift; i++)
                {
                    entry = entry.Append(entry[0]);
                    entry = entry.Remove(0, 1);
                }

                return entry;
            }

            throw new ArgumentException("Строка не может быть закодирована!");
        }
    }
}
