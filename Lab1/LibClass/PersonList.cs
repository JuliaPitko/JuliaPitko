using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    //TODO: XML
    /// <summary>
    /// Класс списка персон
    /// </summary>
    public class PersonList
    {
        //TODO: XML
        //TODO: RSDN
        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _personArray = new Person[0];

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson (Person person)
        {
            int NumberofPerson = _personArray.Length;

            Person[] newArray = new Person[NumberofPerson + 1];

            for (int i = 0; i < NumberofPerson; i++)
            {
                newArray[i] = this._personArray[i];
            }

            newArray[NumberofPerson] = person;

            _personArray = newArray;
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
            Array.Resize(ref _personArray, 0);
        }

        /// <summary>
        /// Удаление определенного человека
        /// </summary>
        /// <param name="index"></param>
        public void DeletePerson(int index)
        {
            for (int i=index;  i< _personArray.Length-1; i++)
            {
                _personArray[i] = _personArray[i + 1];
            }
            Array.Resize(ref _personArray, _personArray.Length-1);
        }

        /// <summary>
        /// Поиск элемента по индексу, 
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns> возвращает значение по указанному индексу
        public Person GetByIndex (int ind)
        {
            if (0 <= ind && ind < _personArray.Length)
            {
                return _personArray[ind];
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
            for (int i = 0; i < _personArray.Length; i++)
            {
                if (_personArray[i].Name == person.Name &&
                    _personArray[i].LastName == person.LastName &&
                    _personArray[i].Age == person.Age &&
                   _personArray[i].Gender == person.Gender)
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
                return _personArray.Length;
            }
            
        }

        public string[] InfoAboutAllPerson()
        {
            string[] array = new string[_personArray.Length];
            for (int i = 0; i < _personArray.Length; i++)
            {
                array[i] = _personArray[i].Info;
            }
            return array;
        }
       
    }
}
