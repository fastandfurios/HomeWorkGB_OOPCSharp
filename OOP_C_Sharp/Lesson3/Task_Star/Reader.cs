using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Task_Star
{
    internal sealed class Reader
    {
        /// <summary> Читает из файла информацию </summary>
        /// <returns>строка с текстом</returns>
        internal string Read()
        {
            try
            {
                const string fileName = "Content.txt";

                using var streamReader = new StreamReader(fileName);

                var buffer = new StringBuilder();
                while(streamReader.ReadLine() is { } line)
                    buffer.AppendLine(line);
                entry = buffer.ToString();

                return entry;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }
    }
}
