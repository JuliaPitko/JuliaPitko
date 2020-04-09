using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibClass;

namespace Laba1
{
    //TODO: XML
    /// <summary>
    /// Основной класс 
    /// </summary>
    public class Program
    {
        //TODO: XML
        /// <summary>
        /// Проверка кода
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TODO: RSDN
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
    }
}
