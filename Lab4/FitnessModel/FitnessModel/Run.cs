using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    /// <summary>
    /// Класс для описания бега
    /// </summary>
    public class Run : ActionsBase
    {
        /// <summary>
        /// поле интенсивности
        /// </summary>
        private double _intensive;

        /// <summary>
        /// интенсивность бега
        /// </summary>
        public double Intensive 
        {
            get
            {
                return _intensive;
            }

            set
            {
                _intensive = ValueChecking(value);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="intensive">интенсивность</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время</param>
        /// <param name="distanceOrWeight">дистанция</param>
        public Run
        (
         double intensive,
         double weightPerson,
         double time,
         double distanceOrWeight
        )
        {
            Intensive = intensive;
            WeightPerson = weightPerson;
            Time = time;
            DistanceOrWeight = distanceOrWeight;

        }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Run() { }

        /// <summary>
        /// Расчёт калорий при беге
        /// </summary>
        /// <returns>количество калорий</returns>
        public override double KkalCalculation()
        {
            return WeightPerson * Time* (DistanceOrWeight/ Intensive);
        }
    }
}
