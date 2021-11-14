using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.Task_1
{
    public interface ICoder
    {
        StringBuilder Decode(StringBuilder entry);
        StringBuilder Encode(StringBuilder entry);
    }
}
