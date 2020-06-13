using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    /// <summary>
    /// класс дитишко
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Проверка возраста
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                //TODO: добавила возраст до 17 
                if (!(value <= 17))
                {
                    throw new ArgumentOutOfRangeException(
                        "Введённое значение недопустимо. Введите " +
                        "меньше 18");
                }

                _age = value;
            }
        }

        /// <summary>
        /// отец
        /// </summary>
        private Adult _father;

        /// <summary>
        /// отец
        /// </summary>
        public Adult Father
        {
            get
            {
                return _father;
            }

            set
            {
                _father = value;
            }
        }

        /// <summary>
        /// мать
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother
        {
            get
            {
                return _mother;
            }

            set
            {
                _mother = value;
            }
        }

        /// <summary>
        /// детский сад или школа
        /// </summary>
        private string _kindergartenOrSchool;

        /// <summary>
        /// Информация о детском саде/школе
        /// </summary>
        public string KindergartenOrSchool
        {
            get
            {
                return string.IsNullOrEmpty(_kindergartenOrSchool)
                    ? "Информация о детском саде/школе не задана"
                    : $" {_kindergartenOrSchool}.";
            }
            set
            {
                _kindergartenOrSchool = value;
            }
        }

        /// <summary>
        /// Получение информации о ребетенке
        /// </summary>
        /// <returns>Информация о ребетенке</returns>
        public override string Info()
        {
            var personInfo = base.Info() + $"\nНазвание школы или сада:" +
                $"{KindergartenOrSchool}";

            if (Mother != null)
            {
                personInfo += $"\nМать: {Mother.Name} {Mother.LastName}";
            }

            if (Father != null)
            {
                personInfo += $"\nОтец: {Father.Name} {Father.LastName}";
            }

            return personInfo;
        }

        /// <summary>
        /// Выпить молочный коктейль
        /// </summary>
        /// <returns>пьёт молочный коктейль</returns>
        public string DrinkMilkShake()
        {
            return Info() + "\nПьёт молочный коктейль";
        }
    }
}
