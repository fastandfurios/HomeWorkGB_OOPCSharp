using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Task_Star
{
    internal sealed class Writer
    {
        /// <summary> Записывает результат поиска в файл </summary>
        /// <param name="entry">строка с результатом поиска</param>
        internal void Write(string entry)
        {
            try
            {
                var fileName = "Result.txt";

                using var stream = new StreamWriter(fileName, true, Encoding.UTF8);
                stream.Write(entry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
