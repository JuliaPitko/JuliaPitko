using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    /// <summary>
    /// Формирование рандомной персоны
    /// </summary>
    public static class RandomPerson
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Получение случайной персоны (ребенок или взрослый)
        /// </summary>
        /// <returns>Сгенерированный ребенок или взрослый</returns>
        public static PersonBase GetRandomPerson()
        {
            if (_random.Next(0, 2) != 0)
            {
                return GetRandomAdult();
            }

            else
            {
                return GetRandomChild();
            }
        }

        /// <summary>
        /// Генерирует взрослого человека
        /// </summary>
        /// <param name="forMarriage">генерирует супруга</param>
        /// <param name="supouse">Супруг</param>
        /// <returns></returns>
        public static Adult GetRandomAdult(bool forMarriage = false,
                                                Adult supouse = null)
        {

            var randomAdult = new Adult();

            RandomInfoPerson(randomAdult);

            randomAdult.Age = _random.Next(18, 125);

            if (!forMarriage)
            {
                randomAdult.MaritalStatus = (MaritalStatus)_random.Next(0, 4);

                if (randomAdult.MaritalStatus == MaritalStatus.Married)
                {
                    randomAdult.Supouse =
                        GetRandomAdult(true, randomAdult);
                }
            }

            else
            {
                randomAdult.MaritalStatus = MaritalStatus.Married;
                randomAdult.Supouse = supouse;
            }

            var companies = new String[]
            {
                "СО ЕЭС", "ФСК ЕЭС", "НИ ТПУ",
                "КФС", "Школа", "Библиотека",
                "Шахты", "Рынок", "Больница"
            };

            randomAdult.PlaceOfWork = companies[_random.Next(0, companies.Length)];

            GetPasportData(randomAdult);

            return randomAdult;
        }

        /// <summary>
        /// формирование случайного ребенка
        /// </summary>
        /// <returns>случайный ребенок</returns>
        public static Child GetRandomChild()
        {
            var randomChild = new Child();
            RandomInfoPerson(randomChild);

            randomChild.Age = _random.Next(0, 18);

            bool hasMother = _random.Next(0, 2) != 0;

            if (hasMother)
            {
                randomChild.Mother = GetRandomAdult();
            }

            bool hasFather = _random.Next(0, 2) != 0;

            if (hasFather)
            {
                randomChild.Father = GetRandomAdult();
            }

            var schools = new String[]
            {
                "№29", "№22", "№143",
                "Лицей при СКФУ", "Лицей при ТГУ", "№195",
                "Лицей при ТПУ", "№77", "№167", "№666",
                "№8"
            };

            randomChild.KindergartenOrSchool = schools[_random.Next(0, schools.Length)];

            return randomChild;
        }

       /// <summary>
       /// Генерация паспортных двнных
       /// </summary>
       /// <param name="adult">Взрослый человек</param>
        private static void GetPasportData(Adult adult)
        {
            var _passport = _random.Next(100000, 999999).ToString();

            adult.Passport = _passport;
        }

        /// <summary>
        /// Заполняет базовые поля человека
        /// </summary>
        /// <param name="person">человек</param>
        public static void RandomInfoPerson(PersonBase person)
        {

            var maleFirstName = new String[]
            {
                "Иван", "Антон", "Дмитрий",
                "Сергей", "Александр", "Илья"
            };

            var femaleFirstName = new String[]
            {
                "Юлия", "Анна", "Мария",
                "Светлана", "Дарья", "Татьяна"
            };

            var lastName = new String[]
            {
                "Будько", "Питько", "Андриенко",
                "Жук", "Фоменко", "Андрейченко"
            };

            var genderNumber = _random.Next(1, 3);
            switch (genderNumber)
            {
                case 1:
                    {
                        person.Gender = Gender.Male;
                        person.Name = maleFirstName[_random.Next(0,
                                                maleFirstName.Length)];
                        break;
                    }
                case 2:
                    {
                        person.Gender = Gender.Female;
                        person.Name = femaleFirstName[_random.Next(0,
                                                 femaleFirstName.Length)];
                        break;
                    }
            }

            person.LastName = lastName[_random.Next(0, lastName.Length)];

        }
    }
}
