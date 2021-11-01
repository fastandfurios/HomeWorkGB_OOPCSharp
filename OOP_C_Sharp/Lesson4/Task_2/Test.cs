using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson4.Task_2
{
    public class Test
    {
        public void Run()
        {
            var building_1 = Creator.CreateBuild();
            building_1.Height = 27;
            building_1.Floors = 9;
            building_1.NumberApartments = 252;
            building_1.NumberEntrances = 7;

            var building_2 = Creator.CreateBuild();

            Creator.RemovedBuilding(2);

            var building_3 = Creator.CreateBuild();
            
            foreach (DictionaryEntry building in Creator.Buildings)
            {
               WriteLine($"{building.Value}\n");
            }

            Print(building_3);
        }

        private void Print(Building building)
        {
            WriteLine($"Данные по дому: {building.Id}");
            WriteLine($"Высота этажа: {building.GetHeightFloor()} м");
            WriteLine($"Количество квартир на этаже: {building.GetNumberApartmentsFloor()}");
            WriteLine($"Количество квартир в подъезде: {building.GetNumberApartmentsEntrance()}");
        }
    }
}
