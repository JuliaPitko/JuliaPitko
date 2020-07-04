using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    /// <summary>
    /// Класс параметров жима лежа
    /// </summary>
    public class BenchPress : ActionsBase
    {
        /// <summary>
        /// Поле подходов
        /// </summary>
        private double _iteration;

        /// <summary>
        /// Подходы
        /// </summary>
        public double Iteration 
        {
            get
            {
                return _iteration;
            }

            set
            {
                _iteration = ValueChecking(value);
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="iteration">подходы</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время</param>
        /// <param name="distanceOrWeight">дистанция</param>
        public BenchPress
         (
         double iteration,
         double weightPerson,
         double time,
         double distanceOrWeight
         )
        {
            Iteration = iteration;
            WeightPerson = weightPerson;
            Time = time;
            DistanceOrWeight = distanceOrWeight;
        }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public BenchPress() { }

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns>калории</returns>
        public override double KkalCalculation()
        {
            return (DistanceOrWeight / WeightPerson) * Iteration * Time;
        }
    }
}
