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
    [Serializable]
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
        /// Название активности
        /// </summary>
        public override string Description
        {
            get
            {
                return "Бег";
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="intensive">интенсивность</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время</param>
        /// <param name="distanceOrWeight">дистанция</param>
        public Run(double intensive, double weightPerson,
                    double time, double distanceOrWeight)
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
       /// Конструктор через общие для всех параметры
       /// </summary>
       /// <param name="weightPerson"></param>
       /// <param name="time"></param>
        public Run (double weightPerson, double time)
        {
            WeightPerson = weightPerson;
            Time = time;
        }

        /// <summary>
        /// Расчёт калорий при беге
        /// </summary>
        /// <returns>количество калорий</returns>
        public override double KkalCalculation
        {
            get 
            {
                return WeightPerson * Time * (DistanceOrWeight / Intensive);
            }
            
        }
    }
}
