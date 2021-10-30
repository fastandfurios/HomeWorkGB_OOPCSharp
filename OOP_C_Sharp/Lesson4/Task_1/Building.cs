using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Task_1
{
    public class Building
    {
        private static int _id;
        private decimal _height;
        private int _floors;
        private int _numberApartments;
        private int _numberEntrances;

        public decimal Height { set => _height = Check(value); }
        public int Floors { set => _floors = Check(value); }
        public int NumberApartments { set => _numberApartments = Check(value); }
        public int NumberEntrances { set => _numberEntrances = Check(value); }

        public Building() => GenerateId();

        /// <summary> Генерирует номер здания </summary>
        private void GenerateId() => _id++;

        /// <summary> Возвращает высоту этажа здания </summary>
        /// <returns>высота этажа</returns>
        public decimal GetHeightFloor() => _height / _floors;

        /// <summary> Возвращает количество квартир в подъезде </summary>
        /// <returns>количество квартир в подъезде</returns>
        public int GetNumberApartmentsEntrance() => _numberApartments / _numberEntrances;

        /// <summary> Возвращает количество квартир на этаже </summary>
        /// <returns>количество квартир</returns>
        public int GetNumberApartmentsFloor() => _numberApartments / _numberEntrances / _floors;

        /// <summary> Проверяет входящие данные на отрицательный значения и на 0. Если содержится отрицательное значение или 0, выдает исключение </summary>
        /// <typeparam name="T">тип значения</typeparam>
        /// <param name="value">значение параметра</param>
        /// <returns>значение соответствующего типа либо исключение </returns>
        private T Check<T>(T value) where T: IComparable<T> 
            => value.CompareTo(default) > 0 ? value : throw new ArgumentException("Недопустимое значение!");

        public override string ToString() 
            => $"Дом номер: {_id}\nВысота дома: {_height} м\nКоличество этажей: {_floors}\nКвартир: {_numberApartments}\nПодъездов: {_numberEntrances}";
    }
}
