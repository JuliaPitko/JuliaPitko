using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace FitnessView
{
    class RandomAction
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Случайное число enum
        /// </summary>
        private static Random _randomEnum = new Random();

        /// <summary>
        /// Константа для максимального значения
        /// </summary>
        private const int _max = 1000;

        /// <summary>
        /// Константа для минимального значения
        /// </summary>
        private const int _min = 0;

        /// <summary>
        /// Константа шага
        /// </summary>
        private const int _step = 100;

        /// <summary>
        /// Создание случайного дробного числа
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="divider"></param>
        /// <returns></returns>
        private static double GetRandomDouble(int min,
                                         int max, int divider)
        {
            double randomDouble = Convert.ToDouble
                (_random.Next(min, max) / divider);

            return randomDouble;
        }

        public static ActionsBase CreateAction()
        {
            int typeActions = _random.Next(0, 3);
            int typeSwimming = _randomEnum.Next(0, 3);

            switch (typeActions)
            {
                case 0:
                {
                        var randomRun = new Run
                        {
                            Intensive = GetRandomDouble(-_max, _max, _step),
                            WeightPerson = GetRandomDouble(_min, _max, _step),
                            Time = GetRandomDouble(-_max, _max, _step),
                            DistanceOrWeight = GetRandomDouble(-_max, _max, _step)
                        };

                        return randomRun;

                }
                case 1:
                    {
                        var randomBenchPress = new BenchPress
                        {
                            Iteration = GetRandomDouble(-_max, _max, _step),
                            WeightPerson = GetRandomDouble(_min, _max, _step),
                            Time = GetRandomDouble(-_max, _max, _step),
                            DistanceOrWeight = GetRandomDouble(-_max, _max, _step)
                        };

                        return randomBenchPress;
                    }
                case 2:
                    {
                        var randomSwimming = new Swimming
                        {
                            WeightPerson = GetRandomDouble(_min, _max, _step),
                            Time = GetRandomDouble(-_max, _max, _step),
                            DistanceOrWeight = GetRandomDouble(-_max, _max, _step)
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
