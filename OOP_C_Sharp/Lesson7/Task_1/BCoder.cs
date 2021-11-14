using System.Text;
using static System.Convert;

namespace Lesson7.Task_1
{
    public class BCoder : ICoder
    {
        private char _firstSymbol;
        private char _lastSymbol;

        /// <summary> Первый символ алфавита </summary>
        public char FirstSymbolAlphabet { get => _firstSymbol; set => _firstSymbol = value; }

        /// <summary> Последний символ алфавита </summary>
        public char LastSymbolAlphabet { get => _lastSymbol; set => _lastSymbol = value; }

        /// <summary> Декодирует закодированную строку, меняя местами начальные символы с конечными символами </summary>
        /// <param name="entry">входящая строка</param>
        /// <returns>раскодированная строка</returns>
        /// <exception cref="ArgumentException">Исключение появляется, если входящая строка была NULL, либо строка стостояла только из символов-разделителей</exception>
        public StringBuilder Decode(StringBuilder entry)
        {
            if (!entry.IsNullOrWiteSpace())
            {
                for (int i = 0; i < entry.Length; i++)
                {
                    if (Char.IsLower(entry[i]))
                    {
                        _firstSymbol = Char.ToLower(_firstSymbol);
                        _lastSymbol = Char.ToLower(_lastSymbol);
                        entry[i] = ToChar(_firstSymbol - (entry[i] - _lastSymbol));
                    }
                    else
                    {
                        _firstSymbol = Char.ToUpper(_firstSymbol);
                        _lastSymbol = Char.ToUpper(_lastSymbol);
                        entry[i] = ToChar(_firstSymbol - (entry[i] - _lastSymbol));
                    }
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
            if(!entry.IsNullOrWiteSpace())
            {
                for (int i = 0; i < entry.Length; i++)
                {
                    if(Char.IsLower(entry[i]))
                    {
                        _firstSymbol = Char.ToLower(_firstSymbol);
                        _lastSymbol = Char.ToLower(_lastSymbol);
                        entry[i] = ToChar(_lastSymbol - (entry[i] - _firstSymbol));
                    }
                    else
                    {
                        _firstSymbol = Char.ToUpper(_firstSymbol);
                        _lastSymbol = Char.ToUpper(_lastSymbol);
                        entry[i] = ToChar(_lastSymbol - (entry[i] - _firstSymbol));
                    }
                }
                
                return entry;
            }

            throw new ArgumentException("Строка не может быть закодирована!");
        }
    }
}
