using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    /// <summary>
    /// Класс списка персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        private PersonBase[] _personArray;

        /// <summary>
        /// Конструктор для пустого списка людей
        /// </summary>
        public PersonList()
        {
            _personArray = new PersonBase[0];
        }

        /// <summary>
        /// Добавление нового человека
        /// </summary>
        /// <param name="person">Человек</param>
        public void AddPerson (PersonBase person)
        {
            //TODO: RSDN исправлено
            int numberofPerson = _personArray.Length;

            PersonBase[] newArray = new PersonBase[numberofPerson + 1];

            for (int i = 0; i < numberofPerson; i++)
            {
                newArray[i] = this._personArray[i];
            }

            newArray[numberofPerson] = person;

            _personArray = newArray;
        }

        /// <summary>
        /// Добавление массива людей
        /// </summary>
        /// <param name="persons">Массив людей</param>
        public void AddRangePeople(PersonBase[] persons)
        {
            foreach (PersonBase person in persons)
            {
                AddPerson(person);
            }
        }

        /// <summary>
        /// Удаление всех элементов списка и по индексу
        /// </summary>
        public void DeleteAllPerson()
        {
            Array.Resize(ref _personArray, 0);
        }

        /// <summary>
        /// Удаление определенного человека
        /// </summary>
        /// <param name="index">Индекс человека в списке</param>
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
        /// <param name="index">Индекс человека</param>
        /// <returns>возвращает значение по указанному индексу</returns> 
        public PersonBase this [int index]
        {
            get
            {
                if (0 <= index && index < _personArray.Length)
                {
                    return _personArray[index];
                }
                else
                {
                    throw new ArgumentException("Такого элемента нет");
                }
            }
        }

        /// <summary>
        /// Нахождение индекса по элементу
        /// </summary>
        /// <param name="person">Человек</param>
        /// <returns>Индекс человека</returns>
        public int IndexOf(PersonBase person)
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

    }
}
