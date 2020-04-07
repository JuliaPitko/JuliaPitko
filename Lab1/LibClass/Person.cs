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
        private string _Name;

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format("{0} is null or empty!", value));
                }
                _Name = value;
            }
        }

        //TODO: RSDN//TODO: XML
        private string _LastName;

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        string.Format("{0} is null or empty!", value));
                }
                _LastName = value;
            }
        }

        //TODO: XML//TODO: RSDN
        private int _Age;

        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age
        {
            get 
            {
                return _Age;
            }
            private set
            {
                //TODO: Ограничение сверху
                if (value >= 0)
                {
                    _Age = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        
        //TODO: XML
        public Gender Gender { get; set; } 

        //TODO: XML
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