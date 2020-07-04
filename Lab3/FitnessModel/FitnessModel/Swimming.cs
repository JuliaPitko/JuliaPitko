using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessModel
{
    public class Swimming : ActionsBase
    {
        /// <summary>
        /// Сжигаемые калории в зависимости от стиля
        /// </summary>
        private double _kkal;
        
        /// <summary>
        /// Калории зависящие от стиля
        /// </summary>
        public double Kkal { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="distanceOrWeight">расстояние</param>
        /// <param name="weightPerson">вес человека</param>
        /// <param name="time">время заплыва</param>
        public Swimming
        (
        double distanceOrWeight,
        double weightPerson,
        double time,
        double kkal
        )
        {
            DistanceOrWeight = distanceOrWeight;
            WeightPerson = weightPerson;
            Time = time;
            Kkal = kkal;
        }

       /// <summary>
       /// пустой конструктор
       /// </summary>
        public Swimming() { }

        public override double KkalCalculation()
        {
            return  (DistanceOrWeight/ WeightPerson) * Kkal * Time;
        }
    }
}
