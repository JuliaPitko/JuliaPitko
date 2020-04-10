using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibClass
{
    class RandomPerson
    {
        public static Person GetRandomPerson()
        {
            string[] maleFirstName = new string []
            { 
                "Иван", "Антон", "Дмитрий",
                "Сергей", "Александр", "Илья"
            };
            string[] femaleFirstName = new string[]
            { 
                "Юлия", "Анна", "Мария",
                "Светлана", "Дарья", "Татьяна"
            };
            string[] lastName = new string[]
            { 
                "Будько", "Питько", "Андриенко",
                "Жук", "Фоменко", "Андрейченко"
            };
            var rand = new Random();
            var addGender = Gender.Female;

            switch (rand.Next(1,3))
            {
                case 1:
                    addGender = Gender.Male;
                    break;
                case 2:
                    addGender = Gender.Female;
                    break;

            }

            string name =
                addGender == Gender.Female
                ? femaleFirstName[rand.Next(femaleFirstName.Length)]
                : maleFirstName[rand.Next(maleFirstName.Length)];

            return new Person(name, 
                lastName[rand.Next(lastName.Length)],
                rand.Next(1, 125), addGender);
        }
    }
}
