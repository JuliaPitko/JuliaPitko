using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LibClass
{
    /// <summary>
    /// Класс содержит параметры человека
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя человека
        /// </summary>
        private string _name;

        /// <summary>
        /// Свойство поля имя
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                CheckCorrectOfName(value);
                _name = CheckRegister(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _lastName;

        /// <summary>
        /// Фамилия человека
        /// </summary> 
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                CheckCorrectOfName(value);
                _lastName = CheckRegister(value);
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        protected int _age;

        /// <summary>
        /// Возраст человека
        /// </summary>  
        public abstract int Age
        {
            get; set; 
        }
        
        /// <summary>
        /// Свойство пол
        /// </summary> 
        public Gender Gender { get; set; }

        /// <summary>
        /// Пустой конструктор персона
        /// </summary>
        public PersonBase() { }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Параметр имени</param>
        /// <param name="lastName">Параметр фамилии</param>
        /// <param name="age">Параметр возраста</param>
        /// <param name="gender">Параметр пол</param>
        public PersonBase(string name, string lastName, int age, Gender gender)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Информация о человеке
        /// </summary>
        /// <returns>строка с базовыми данными</returns>
        public virtual string Info()
        {
            return $"Name: {Name}\nLastName: {LastName}\n" +
                   $"Age: {Age}\nGender:{Gender}";
        }

        /// <summary>
        /// Проверка использования русского и английского алфавита
        /// </summary>
        /// <param name="value">Входная строка</param>
        /// <returns>Корректную строку</returns>
        public static string CheckCorrectOfName (string value)
        {
            if (value == string.Empty)
            {
                throw new Exception("Необходимо ввести данные!");
            }
            else 
            {
                var eng = new Regex (@"[A-Z] + [a-z]+");
                var rus = new Regex (@"[А - Я] + [а - я]+");
                var numbers = new Regex(@"[0-9]");
                if ((eng.IsMatch(value) && rus.IsMatch(value)))
                {
                    throw new ArgumentException ("Имя и Фамилия только"+
                        "на русском или английском языке! Повторите:");
                }
                if (numbers.IsMatch(value))
                {
                    throw new ArgumentException("Имя и фамилия не должны" +
                        "содержать цифр! Повторите ввод");
                }
                else
                {
                    return value;
                }
            }
        }

        /// <summary>
        /// Проверка регистра имени
        /// </summary>
        /// <param name="value">строка с клавиатуры</param>
        /// <returns>Верный регистр</returns>
        public string CheckRegister(string value)
        {
            string FirstLetterToUpper(string word)
            {
                return word.Substring(0, 1).ToUpper() +
                    word.Substring(1, word.Length - 1).ToLower();
            }

            var symbols = new[] { "-", " " };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    string[] words = value.Split(symbol.ToCharArray()[0]);
                    return words.Length > 1
                        ? $"{FirstLetterToUpper(words[0])}" +
                        $"{symbol}{FirstLetterToUpper(words[1])}"
                        : FirstLetterToUpper(value);
                }
            }
            return FirstLetterToUpper(value);
        }
    }
}