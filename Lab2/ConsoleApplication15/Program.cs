using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibClass;
using System.Text.RegularExpressions;

namespace Laba2
{
    /// <summary>
    /// Основной класс 
    /// </summary>
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Нажмите любую клавишу для работы");
            Console.WriteLine("");

            Console.ReadKey();

            Console.WriteLine("Генерация 7 случайных людей");

            var persons = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                persons.AddPerson(RandomPerson.GetRandomPerson());
            }

            for (int i = 0; i < persons.NumberOfPeople; i++)
            {
                Console.WriteLine(persons[i].Info());
                Console.WriteLine();
            }

            Console.WriteLine("Готово");

            Console.ReadKey();

            Console.WriteLine("Четвертая персона в списке");

            switch (persons[3])
            {
                case Adult adult:
                {
                    Console.WriteLine("Взрослый");
                    Console.WriteLine(adult.DrinkBeer());
                    break;
                }

                case Child child:
                {
                    Console.WriteLine("Ребёнок");
                    Console.WriteLine(child.DrinkMilkShake());
                    break;
                }
            }

            Console.ReadKey();
        }
      
        /// <summary>
        /// Метод проверки имени и фамилиии
        /// </summary>
        /// <param name="message">Информация для пользователя</param>
        /// <returns>Корректные фамилию и имя</returns>
        public static string CheckCorrectnessOfNames(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    return PersonBase.CheckCorrectOfName(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка:{e.Message}");
                }
            }
        }

        /// <summary>
        /// Проверка пола
        /// </summary>
        /// <param name="message">информация об ошибке</param>
        /// <returns></returns>
        public static int GetCorrectGender(string message)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    var gender = Convert.ToInt32(NumbersFromConsole());
                    return gender;
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
                var readKey = Console.ReadKey(true);
                switch (readKey.Key)
                {
                    case ConsoleKey.Backspace:
                    {
                        if (result.Length > 0)
                        {
                            result = result.Remove(startIndex: result.Length - 1,
                                count: 1);
                            Console.Write(value: $"{readKey.KeyChar} {readKey.KeyChar}");
                        }

                        break;
                    }
                    case ConsoleKey.Enter:
                    {
                        Console.WriteLine();
                        return result;
                    }
                    default:
                    {
                        if (char.IsDigit(c: readKey.KeyChar))
                        {
                            Console.Write(value: readKey.KeyChar);
                            result += readKey.KeyChar;
                        }

                        break;
                    }
                }
            }

        }
    }
}
