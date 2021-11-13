using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public static class StringBuilderEx
    {
        public static bool IsNullOrWiteSpace(this StringBuilder entry) => string.IsNullOrWhiteSpace(entry.ToString()) ? true : false;
    }
}
