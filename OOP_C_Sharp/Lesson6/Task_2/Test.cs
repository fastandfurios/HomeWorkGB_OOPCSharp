using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_2
{
    public class Test
    {
        public void Run()
        {
            Figure rectangle = new Rectangle();
            Point a = (Point)rectangle;
            Point b = (Point)rectangle;
            Point c = (Point)rectangle;
            Point d = (Point)rectangle;
            a.Coordinates = (X: 1, Y: 1);
            b.Coordinates = (X: 3, Y: 1);
            c.Coordinates = (X: 1, Y: 2);
            d.Coordinates = (X: 3, Y: 2);

            Console.WriteLine(rectangle);
            rectangle.GetArea();
        }
    }
}
