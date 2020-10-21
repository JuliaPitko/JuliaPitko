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
    [Serializable]
    public abstract class ActionsBase
    {
        /// <summary>
        /// Минимальный вес
        /// </summary>
        public const double MinWeight = 2.3;

        /// <summary>
        /// Максимальный вес
        /// </summary>
        public const double MaxWeight = 410;

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
                _weightPerson = CheckWeightPerson(value);
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
         /// Проверка введенного веса
         /// </summary>
         /// <param name="value"> введенный вес</param>
         /// <returns></returns>
        public static double CheckWeightPerson(double value)
        {
            {
                if (value < MinWeight)
                {
                    throw new ArgumentException("Вес не должен быть " +
                        $"ниже {MinWeight} кг");
                }
                if (value > MaxWeight)
                {
                    throw new ArgumentException("Вес не может быть " +
                        $"больше {MaxWeight} кг");
                }
                return value;
            }
        }

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns></returns>
        public virtual double KkalCalculation { get; }

        /// <summary>
        /// Описание вида активности
        /// </summary>
        public virtual String Description { get; }

    }
}
