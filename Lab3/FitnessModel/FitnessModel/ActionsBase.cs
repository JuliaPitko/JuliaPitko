using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    /// <summary>
    /// Базовый класс, который содержит основные параметры расчётов
    /// </summary>
    public abstract class ActionsBase
    {
        /// <summary>
        /// Дистанция или вес штанги 
        /// </summary>
        private double _distanceOrWeight;

        /// <summary>
        /// расстояние или вес
        /// </summary>
        public double DistanceOrWeight 
        {
            get
            {
                return _distanceOrWeight;
            }

            set
            {
                _distanceOrWeight = ValueChecking(value);
            }
        }

        /// <summary>
        /// время тренировки
        /// </summary>
        private double _time;

        /// <summary>
        /// Время
        /// </summary>
        public double Time 
        {
            get
            {
                return _time;
            }

            set
            {
                _time = ValueChecking(value);
            }
        }

        /// <summary>
        /// поле вес человека
        /// </summary>
        private double _weightPerson;

        /// <summary>
        /// Вес человека
        /// </summary>
        public double WeightPerson 
        {
            get
            {
                return _weightPerson;
            }

            set
            {
                _weightPerson = ValueChecking(value);
            }
        }

        /// <summary>
        /// Проверка значений
        /// </summary>
        /// <param name="value">переданное значение</param>
        /// <returns>проверенное значение</returns>
        protected double ValueChecking(double value)
        {

            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                throw new ArgumentException(
                    "Значение не может быть неопределенным");
            }

            if (value < 0)
            {
                throw new ArgumentException(
                    "Значение не может быть отрицательным");
            }

            return value;
        }

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns></returns>
        public abstract double KkalCalculation();

    }
}
