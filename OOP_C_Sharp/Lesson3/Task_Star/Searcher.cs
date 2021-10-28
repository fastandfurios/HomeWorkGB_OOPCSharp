using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson3.Task_Star
{
    internal sealed class Searcher
    {
        /// <summary> Ищет почту </summary>
        /// <param name="s">изменяемая строка</param>
        internal void SearchMail(ref string s)
        {
            var entry = string.Empty;
            var rx = new Regex(@"[a-z]*@[a-z]*.[a-z]*", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match match in rx.Matches(s))
            {
                entry += match.Value + "\n";
            }

            s = entry;
        }
    }
}
