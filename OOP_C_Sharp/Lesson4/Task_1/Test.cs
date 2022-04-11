using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson4.Task_1
{
    internal sealed class Test
    {
        public void Run()
        {
            var building_1 = new Building();
            building_1.Height = 27;
            building_1.Floors = 9;
            building_1.NumberApartments = 252;
            building_1.NumberEntrances = 7;
            Print(building_1);

            WriteLine();

            var building_2 = new Building();
            building_2.Height = 15;
            building_2.Floors = 5;
            building_2.NumberApartments = 80;
            building_2.NumberEntrances = 4;
            Print(building_2);
        }

        private void Print(Building building)
        {
            WriteLine(building);
            WriteLine($"Высота этажа: {building.GetHeightFloor()} м");
            WriteLine($"Количество квартир на этаже: {building.GetNumberApartmentsFloor()}");
            WriteLine($"Количество квартир в подъезде: {building.GetNumberApartmentsEntrance()}");
        }
    }
}
