using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Task_Star
{
    internal sealed class Test
    {
        internal void Run()
        {
            var searcher = new Searcher();
            var reader = new Reader();
            var writer = new Writer();

            var entry = reader.Read();
            Console.WriteLine("Чтение данных завершено!");
            searcher.SearchMail(ref entry);
            Console.WriteLine("Поиск завершен!");
            writer.Write(entry);
            Console.WriteLine("Запись данных завершена!");
        }
    }
}
