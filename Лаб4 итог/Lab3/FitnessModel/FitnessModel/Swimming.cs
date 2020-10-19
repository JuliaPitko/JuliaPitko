using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    /// <summary>
    /// Плавание
    /// </summary>
    [Serializable]
    public class Swimming : ActionsBase
    {
        /// <summary>
        /// Соответсвие каллорий стилю плавания
        /// </summary>
        private Dictionary<SwimmingEnum, double> _swimmingKkalDictionary =
            new Dictionary<SwimmingEnum, double>()
            {
                {SwimmingEnum.SlowBrace, 6.0},
                {SwimmingEnum.QuickCrawl, 7.0},
                {SwimmingEnum.SlowСrawl, 8.0}
            };

        /// <summary>
        /// Сжигаемые калории в зависимости от стиля
        /// </summary>
        private double _kkal;

        /// <summary>
        /// Поле стилей плавания
        /// </summary>
        private SwimmingEnum _swimmingEnum;

        /// <summary>
        /// Свойство стиль плавания
        /// </summary>
        public SwimmingEnum SwimmingEnum
        {
            get => _swimmingEnum;
            
            set
            {
                _swimmingEnum = value;
                _kkal = _swimmingKkalDictionary[_swimmingEnum];
            }
        }

        /// <summary>
        /// Название активности
        /// </summary>
        public override string Description
        {
            get
            {
                return "Плавание";
            }
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="distanceOrWeight">расстояние</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время заплыва</param>
        /// <param name="swimmingEnum">калории от стиля плавания</param>
        public Swimming (double distanceOrWeight, double weightPerson, 
                         double time, SwimmingEnum swimmingEnum)
        {
            DistanceOrWeight = distanceOrWeight;
            WeightPerson = weightPerson;
            Time = time;
            SwimmingEnum = swimmingEnum;
        }

       /// <summary>
       /// пустой конструктор
       /// </summary>
        public Swimming() { }

       /// <summary>
       /// Конструктор через базовые параметры
       /// </summary>
       /// <param name="weightPerson"></param>
       /// <param name="time"></param>
        public Swimming(double weightPerson, double time)
        {
            WeightPerson = weightPerson;
            Time = time;
        }

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns>калории</returns>
        public override double KkalCalculation
        {
            get
            {
                return (DistanceOrWeight / WeightPerson) * _kkal * Time;
            }
        }
    }
}
