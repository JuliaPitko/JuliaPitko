using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibClass;

namespace Laba1
{
    //TODO: XML
    public class Program
    {
        //TODO: XML
        static void Main(string[] args)
        {
            //TODO: RSDN
            var FirstListOfPerson = new PersonList();
            var SecondListOfPerson = new PersonList();
            
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
            FirstListOfPerson.AddRangePeople(FirstList);
            SecondListOfPerson.AddRangePeople(SecondList);
            
            PersonListConsoleView(FirstListOfPerson, nameof(FirstList));
            PersonListConsoleView(SecondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            FirstListOfPerson.AddPerson(new Person("Артем", "Жиленков",
               24, Gender.Male));
            Console.WriteLine("Добавление нового человека");
            PersonListConsoleView(FirstListOfPerson, nameof(FirstList));
            Console.ReadKey();

            Console.WriteLine("Копирование человека из первого списка во второй");
            SecondListOfPerson.AddPerson(FirstListOfPerson.GetByIndex(1));
            PersonListConsoleView(FirstListOfPerson, nameof(FirstList));
            PersonListConsoleView(SecondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            Console.WriteLine("Удаление второго человека из первого списка");
            FirstListOfPerson.DeletePerson(1);
            PersonListConsoleView(FirstListOfPerson, nameof(FirstList));
            PersonListConsoleView(SecondListOfPerson, nameof(SecondList));
            Console.ReadKey();

            Console.WriteLine("Очистка второго списка");
            SecondListOfPerson.DeleteAllPerson();
            PersonListConsoleView(FirstListOfPerson, nameof(FirstList));
            PersonListConsoleView(SecondListOfPerson, nameof(SecondList));
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
