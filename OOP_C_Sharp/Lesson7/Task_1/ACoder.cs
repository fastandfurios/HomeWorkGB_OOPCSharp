using System.Text;
using static System.Convert;

namespace Lesson7.Task_1
{
    public class ACoder : ICoder
    {
        /// <summary> Декодирует закодированную строку </summary>
        /// <param name="entry">входящая строка</param>
        /// <returns>раскодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Decode(StringBuilder entry)
        {
            if(!entry.IsNullOrWiteSpace())
            {
                for (int i = 0; i < entry.Length; i++)
                {
                    if (entry[i] is 'а' or 'А' or 'a' or 'A')
                    {
                        entry[i] = entry[i] switch
                        {
                            'а' => 'я',
                            'А' => 'Я',
                            'a' => 'z',
                            'A' => 'Z'
                        };
                    }
                    else
                        entry[i] = ToChar(entry[i] - 1);
                }

                return entry;
            }

            throw new ArgumentException("Строка не может быть раскодирована!");
        }

        /// <summary> Кодирует строку </summary>
        /// <param name="entry">входящая строка</param>
        /// <returns>закодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Encode(StringBuilder entry)
        {
            if (!entry.IsNullOrWiteSpace())
            {
                for (int i = 0; i < entry.Length; i++)
                {
                    if (entry[i] is 'я' or 'Я' or 'z' or 'Z')
                    {
                        entry[i] = entry[i] switch
                        {
                            'я' => 'а',
                            'Я' => 'А',
                            'z' => 'a',
                            'Z' => 'A'
                        };
                    }
                    else
                        entry[i] = ToChar(entry[i] + 1);
                }

                return entry;
            }

            throw new ArgumentException("Строка не может быть закодирована!");
        }
    }
}
