using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    /// <summary>
    /// Класс содержит параметры человека
    /// </summary>
    public class Person
    {
        //TODO: RSDN
        private string _name;

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format("{0} is null or empty!", value));
                }
                _name = value;
            }
        }

        //TODO: RSDN//TODO: XML
        private string _lastName;

        /// <summary>
        /// Фамилия человека
        /// </summary> возвращает фамилию человка </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format("{0} is null or empty!", value));
                }
                _lastName = value;
            }
        }

        //TODO: XML//TODO: RSDN
        private int _age;

        /// <summary>
        /// Возраст человека
        /// </summary> проверяет возраст на границу </summary>  
        public int Age
        {
            get 
            {
                return _age;
            }
            private set
            {
                //TODO: Ограничение сверху
                if (value >= 0 || value <= 125)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        
        //TODO: XML
        /// <summary>
        /// Свойство пол
        /// </summary> 
        public Gender Gender { get; set; } 

        //TODO: XML
       /// <summary>
       /// Конструктор класса
       /// </summary>
       /// <param name="firstName">Параметр имени</param>
       /// <param name="lastName">Параметр фамилии</param>
       /// <param name="age">Параметр возраста</param>
       /// <param name="gender">Параметр пол</param>
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            Name = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Информация о человеке
        /// </summary>
        public string Info
        {
            get
            {
                return "Имя: " + Name + ".\tФамилия: " +
                    LastName + ".   \tВозраст: " + Age + ".\tПол: " +
                    Gender + "."; ;
            }
        }
    }
}