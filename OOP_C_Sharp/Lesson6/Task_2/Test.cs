using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Task_2
{
    public class Test
    {
        public static void Run()
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
            rectangle.Color = ConsoleColor.Red;
            rectangle.Visible = true;

            Console.WriteLine(rectangle);
            rectangle.AxisShift(1,1);
            Console.WriteLine(rectangle);

            Figure circle = new Circle();
            Point r = (Point)circle;
            Point g = (Point)circle;
            r.Coordinates = (X: 1, Y: 1);
            g.Coordinates = (X: 6, Y: 1);
            circle.Color = ConsoleColor.Green;
            circle.Visible = true;

            Console.WriteLine(circle);
            circle.AxisShift(1,1);
            Console.WriteLine(circle);
        }
    }
}
