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

                string line;
                string entry = String.Empty;

                while ((line = streamReader.ReadLine()) != null)
                {
                    entry += line + "\n";
                }

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
