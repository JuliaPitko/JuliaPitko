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
    [Serializable]
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
        /// Название активности
        /// </summary>
        public override string Description
        {
            get
            {
                return "Жим штанги";
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="iteration">подходы</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время</param>
        /// <param name="distanceOrWeight">дистанция</param>
        public BenchPress(double iteration, double weightPerson,
            double time, double distanceOrWeight)
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
        /// Конструктор через общие параметры
        /// </summary>
        /// <param name="weightPerson"></param>
        /// <param name="time"></param>
        public BenchPress(double weightPerson, double time)
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
                return (DistanceOrWeight / WeightPerson) * Iteration * Time; 
            }
            
        }
    }
}
