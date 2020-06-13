using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    /// <summary>
    /// Взрослый человек
    /// </summary>
    public class Adult : PersonBase
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
                //TODO: добавила границу с 18
                if (!(18 < value) && !(value <= 128))
                {
                    throw new ArgumentOutOfRangeException(
                        "Введённое значение недопустимо. Введите " +
                        "больше 18 и меньше 129");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Поле паспортных данных
        /// </summary>
        private string _passportData;

        /// <summary>
        /// Данные паспорта
        /// </summary>
        public string Passport
        {
            get
            {
                return string.IsNullOrEmpty(_passportData)
                    ? "Нет информации о паспортных данных."
                    : $"{_passportData}.";
            }
            set
            {
                _passportData = value;
            }
        }

        /// <summary>
        /// семейный статус
        /// </summary>
        private MaritalStatus _maritalStatus;

        /// <summary>
        /// супруг
        /// </summary>
        private Adult _supouse;

        /// <summary>
        /// семейный статус
        /// </summary>
        public MaritalStatus MaritalStatus
        {
            get
            {
                return _maritalStatus;
            }

            set
            {
                _maritalStatus = value;
            }
        }

        /// <summary>
        /// Информация о супруге
        /// </summary>
        public Adult Supouse
        {
            get
            {
                return _supouse;
            }

            set
            {

                if (value == null)
                {
                    throw new ArgumentNullException(
                        $"{nameof(Supouse)}", $"{nameof(Supouse)} value is" +
                        " null!");
                }

                if (MaritalStatus == MaritalStatus.Married &&
                    value.MaritalStatus == MaritalStatus.Married)
                {
                    _supouse = value;
                }

                else
                {
                    throw new ArgumentException(
                        "Необходимо проверить семейное положение");
                }
            }
        }

        /// <summary>
        /// Место работы
        /// </summary>
        private string _placeOfWork;

        /// <summary>
        /// Информация о месте работы
        /// </summary>
        public string PlaceOfWork
        {
            get
            {
                return string.IsNullOrEmpty(_placeOfWork)
                    ? "Нет информации о месте работы."
                    : $"{_placeOfWork}.";
            }
            set
            {
                _placeOfWork = value;
            }
        }

        /// <summary>
        /// Получение информации о взрослом человеке
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            var personInfo = base.Info() + $"\nПаспортные данные: {Passport}" +
                $"\nСемейный статус: {MaritalStatus}";

            if (MaritalStatus == MaritalStatus.Married)
            {
                personInfo += $"\nСупруг: {Supouse.Name} " +
                    $"{Supouse.LastName}";
            }

            personInfo += "\nМесто работы: ";

            if (string.IsNullOrEmpty(PlaceOfWork))
            {
                personInfo += "Безработный";
            }

            else
            {
                personInfo += PlaceOfWork;
            }

            return personInfo;

        }

        /// <summary>
        /// Выпить пиво
        /// </summary>
        /// <returns>пьёт пиво</returns>
        public string DrinkBeer()
        {
            return Info() + "\nПьёт пиво";
        }
    }
}
