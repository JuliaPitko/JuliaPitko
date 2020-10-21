using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace FitnessView
{
    //TODO: RSDN: исправлено
    /// <summary>
    /// Класс, формирующий случайную активность
    /// </summary>
    public static class RandomAction
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Константа для максимального значения
        /// </summary>
        private const int _max = 1000;

        /// <summary>
        /// Генерация случайной активности
        /// </summary>
        /// <returns></returns>
        public static ActionsBase CreateAction()
        {
            int typeActions = _random.Next(0, 3);
            int typeSwimming = _random.Next(1, 4);

            switch (typeActions)
            {
                case 0:
                {
                    var randomRun = new Run
                    {
                        Intensive = _random.NextDouble() * _max,
                        WeightPerson = _random.NextDouble() *
                            ActionsBase.MaxWeight + ActionsBase.MinWeight,
                        Time = _random.NextDouble() * _max,
                        DistanceOrWeight = _random.NextDouble() * _max
                    };

                    return randomRun;

                }
                case 1:
                {
                    var randomBenchPress = new BenchPress
                    {
                        Iteration = _random.NextDouble() * _max,
                        WeightPerson = _random.NextDouble() *
                            ActionsBase.MaxWeight + ActionsBase.MinWeight,
                        Time = _random.NextDouble() * _max,
                        DistanceOrWeight = _random.NextDouble() * _max
                    };

                    return randomBenchPress;
                }
                case 2:
                {
                    var randomSwimming = new Swimming
                    {
                        WeightPerson = _random.NextDouble() *
                            ActionsBase.MaxWeight + ActionsBase.MinWeight,
                        Time = _random.NextDouble() * _max,
                        DistanceOrWeight = _random.NextDouble() * _max,
                        SwimmingEnum = (SwimmingEnum)typeSwimming
                    };

                    return randomSwimming;
                }
                default:
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
