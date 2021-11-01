using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson4.Task_2;

namespace Lesson4.Task_2
{
    public class Creator
    {
        private Creator()
        {
        }

        /// <summary> Возвращает объект здания </summary>
        /// <returns>объект здания</returns>
        public static Building CreateBuild() => AddInListBuilding(new Building());

        /// <summary> Возвращает объект здания с заданной высотой </summary>
        /// <param name="height">высота здания</param
        /// <returns>объект здания</returns>
        public static Building CreateBuild(decimal height) => AddInListBuilding(new Building { Height = height });

        /// <summary> Возвращает объект здания с заданной высотой и этажами </summary>
        /// <param name="height">высота здания</param>
        /// <param name="floors">кол-во этажей</param>
        /// <returns>объект здания</returns>
        public static Building CreateBuild(decimal height, int floors) => AddInListBuilding(new Building { Height = height, Floors = floors });

        /// <summary> Возвращает объект здания с заданной высотой, этажами и квартирами </summary>
        /// <param name="height">высота здания</param>
        /// <param name="floors">кол-во этажей</param>
        /// <param name="numberApartments">кол-во квартир</param>
        /// <returns>объект здания</returns>
        public static Building CreateBuild(decimal height, int floors, int numberApartments) 
            => AddInListBuilding(new Building 
            { 
                Height = height, 
                Floors = floors,
                NumberApartments = numberApartments
            });

        /// <summary> Возвращает объект здания с заданной высотой, этажами, квартирами и подъездами</summary>
        /// <param name="height">высота здания</param>
        /// <param name="floors">кол-во этажей</param>
        /// <param name="numberApartments">кол-во квартир</param>
        /// <param name="numberEntrances">кол-во подъездов</param>
        /// <returns>объект здания</returns>
        public static Building CreateBuild(decimal height, int floors, int numberApartments, int numberEntrances)
            =>  AddInListBuilding(new Building 
            { 
                Height = height, 
                Floors = floors, 
                NumberApartments = numberApartments, 
                NumberEntrances = numberEntrances 
            });

        /// <summary> Добавляет здание в список зданий </summary>
        /// <param name="building">объект здания</param>
        /// <returns>объект здания</returns>
        private static Building AddInListBuilding(Building building)
        {
            Buildings.Add(building.Id, building);
            return building;
        }

        /// <summary> Удаляет здание из списка </summary>
        /// <param name="id">номер здания</param>
        public static void RemovedBuilding(int id) => Buildings.Remove(id);

        public static Hashtable Buildings { get; private set; } = new();
    }
}
