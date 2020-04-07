using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    //TODO: XML
    public class PersonList
    {
        //TODO: XML
        //TODO: RSDN
        private Person[] PersonArray = new Person[0];

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson (Person person)
        {
            int NumberofPerson = PersonArray.Length;

            Person[] newArray = new Person[NumberofPerson + 1];

            for (int i = 0; i < NumberofPerson; i++)
            {
                newArray[i] = this.PersonArray[i];
            }

            newArray[NumberofPerson] = person;

            PersonArray = newArray;
        }

        /// <summary>
        /// Добавление массива людей
        /// </summary>
        /// <param name="persons"></param>
        public void AddRangePeople(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }

        /// <summary>
        /// Удаление всех элемпентов списака и по индексу
        /// </summary>
        public void DeleteAllPerson()
        {
            Array.Resize(ref PersonArray, 0);
        }

        /// <summary>
        /// Удаление определенного человека
        /// </summary>
        /// <param name="index"></param>
        public void DeletePerson(int index)
        {
            for (int i=index;  i< PersonArray.Length-1; i++)
            {
                PersonArray[i] = PersonArray[i + 1];
            }
            Array.Resize(ref PersonArray, PersonArray.Length-1);
        }

        /// <summary>
        /// Поиск элемента по индексу, 
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns> возвращает значение по указанному индексу
        public Person GetByIndex (int ind)
        {
            if (0 <= ind && ind < PersonArray.Length)
            {
                return PersonArray[ind];
            }
            else
            {
                throw new ArgumentException("Такого элемента нет");
            }
               
        }
        /// <summary>
        /// Нахождение индекса по элементу
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public int IndexOf(Person person)
        {
            for (int i = 0; i < PersonArray.Length; i++)
            {
                if (PersonArray[i].Name == person.Name &&
                    PersonArray[i].LastName == person.LastName &&
                    PersonArray[i].Age == person.Age &&
                   PersonArray[i].Gender == person.Gender)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Количество человек
        /// </summary>
        public int NumberOfPeople
        {
            get
            {
                return PersonArray.Length;
            }
            
        }
       
    }
}
