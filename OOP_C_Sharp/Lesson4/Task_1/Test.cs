using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Task_1
{
    public class Test
    {
        public void Run()
        {
            var building_1 = new Building();
            building_1.Height = 27;
            building_1.Floors = 9;
            building_1.NumberApartments = 252;
            building_1.NumberEntrances = 7;
            Print(building_1);

            Console.WriteLine();

            var building_2 = new Building();
            building_2.Height = 15;
            building_2.Floors = 5;
            building_2.NumberApartments = 80;
            building_2.NumberEntrances = 4;
            Print(building_2);
        }

        private void Print(Building building)
        {
            Console.WriteLine(building);
            Console.WriteLine($"Высота этажа: {building.GetHeightFloor()} м");
            Console.WriteLine($"Количество квартир на этаже: {building.GetNumberApartmentsFloor()}");
            Console.WriteLine($"Количество квартир в подъезде: {building.GetNumberApartmentsEntrance()}");
        }
    }
}
