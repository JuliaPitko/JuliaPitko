using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibClass;
using System.Text.RegularExpressions;

namespace Laba1
{
    //TODO: XML (исправлено)
    /// <summary>
    /// Основной класс 
    /// </summary>
    public class Program
    {
        #region Проверка кода
        //TODO: XML (исправлено)
        /// <summary>
        /// Проверка кода
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TODO: RSDN (исправлено)
            var firstListOfPerson = new PersonList();
            var secondListOfPerson = new PersonList();
            
            var FirstList = new Person[]
            {
                new Person("Darya", "Tuchina", 24, Gender.Female),
                new Person("Aleksey", "Starchenko",24,Gender.Male),
                new Person("Tanya","Strebkova",22,Gender.Female),
            };

            var SecondList = new Person[]
            {
                new Person("Maria", "Sadohina", 23, Gender.Female),
                new Person("Anna", "Darhanova",23,Gender.Female),
                new Person("Julia","Pitko",24,Gender.Female),
            };
            firstListOfPerson.AddRangePeople(FirstList);
            secondListOfPerson.AddRangePeople(SecondList);
            
            PersonListConsoleView(firstListOfPerson, nameof(FirstList));
            PersonListConsoleView(secondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            firstListOfPerson.AddPerson(new Person("Артем", "Жиленков",
               24, Gender.Male));
            Console.WriteLine("Добавление нового человека");
            PersonListConsoleView(firstListOfPerson, nameof(FirstList));
            Console.ReadKey();

            Console.WriteLine("Копирование человека из первого списка во второй");
            secondListOfPerson.AddPerson(firstListOfPerson.GetByIndex(1));
            PersonListConsoleView(firstListOfPerson, nameof(FirstList));
            PersonListConsoleView(secondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            Console.WriteLine("Удаление второго человека из первого списка");
            firstListOfPerson.DeletePerson(1);
            PersonListConsoleView(firstListOfPerson, nameof(FirstList));
            PersonListConsoleView(secondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            Console.WriteLine("Очистка второго списка");
            secondListOfPerson.DeleteAllPerson();
            PersonListConsoleView(firstListOfPerson, nameof(FirstList));
            PersonListConsoleView(secondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            Console.WriteLine("Введите паарметры человека:");

            Person man;
            while(true)
            {
                try
                {
                    man = KeyboardInput();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }
            }
            Console.WriteLine(man.Info);
            secondListOfPerson.AddPerson(man);
            secondListOfPerson.InfoAboutAllPerson();
            Console.ReadKey();

            Console.WriteLine("Случайная генерация человека");

            while (true)
            {
                var person = RandomPerson.GetRandomPerson();
                secondListOfPerson.AddPerson(person);
                secondListOfPerson.InfoAboutAllPerson();
                Console.WriteLine(person.Info);
                Console.ReadKey();

            }
        }
        #endregion
        /// <summary>
        /// Ввод человека
        /// </summary>
        /// <returns>Возвращает параметры человека</returns>
        public static Person KeyboardInput ()
        {
            var name = GetCorrectString("Введите имя: ");
            var lastName = GetCorrectString("Введите фамилию: ");
            int age = GetCorrectInt("Введите возраст: ");
            int vvodGender = GetCorrectInt("Введите пол: 0 - Male," +
                " 1 - Female");
            Gender gender = Gender.Male;
            switch (Convert.ToInt32(gender))
            {
                case 0:
                    gender = Gender.Male;
                    break;
                case 1:
                    gender = Gender.Female;
                    break;
                default:
                    Console.Write("Такого пола нет");
                    break;
            }
            return new Person(name, lastName, age, gender);
        }
        /// <summary>
        /// Вывод персоны
        /// </summary>
        /// <param name="person"></param>
        public static void PersonConsoleView(Person person)
        {
            Console.WriteLine("\n" + person.Info);
        }

        /// <summary>
        /// Вывод списка людей
        /// </summary>
        /// <param name="personList"></param>
        /// <param name="nameOfList"></param>
        public static void PersonListConsoleView(PersonList personList,
            string nameOfList)
        {
            int NumberOfPeople = personList.NumberOfPeople;

            Console.WriteLine(nameOfList + ":\n");

            if (NumberOfPeople == 0)
            {
                Console.WriteLine("Список пуст");
            }

            for (int i = 0; i < NumberOfPeople; i++)
            {
                Console.WriteLine(
                    personList.GetByIndex(i).Info);
                Console.WriteLine();
            }
        }
       /// <summary>
       /// Метод проверки имени и фамилиии
       /// </summary>
       /// <param name="message">Информация для пользователя</param>
       /// <returns>Проверяет строку</returns>
        public static string GetCorrectString (string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    return Person.CheckCorrectOfName(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка:{e.Message}");
                }
            }
        }
        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="message">Информация для пользователя</param>
        /// <returns>Значение возраста</returns>
        public static int GetCorrectInt(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    var age = Convert.ToInt32(NumbersFromConsole());
                    return age;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка:{e.Message}");
                }
            }
        }
        /// <summary>
        /// Запрет на ввод букв
        /// </summary>
        /// <returns>Возвращает число</returns>
        public static string NumbersFromConsole()
        {
            string result = "";
            while (true)
            {
                var k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.Backspace:
                        if (result.Length > 0)
                        {
                            result = result.Remove(startIndex: result.Length - 1,
                                count: 1);
                            Console.Write(value: $"{k.KeyChar} {k.KeyChar}");
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine();
                        return result;
                    default:
                        if (char.IsDigit(c: k.KeyChar))
                        {
                            Console.Write(value: k.KeyChar);
                            result += k.KeyChar;
                        }
                        break;
                }
            }

        }
    }
}
