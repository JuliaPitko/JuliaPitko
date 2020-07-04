using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace TestingApp
{
    public static class ConsoleLoader
    {
        public static Run EnterRunParameters()
        {
            var actionParameters = new Run();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Интенсивность, м/с: (>0) ");
                    actionParameters.Intensive = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    actionParameters.Time = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Вес человека, кг: (>0) ");
                    actionParameters.WeightPerson = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Дистанция, м: (>0) ");
                    actionParameters.DistanceOrWeight = EnterDoubleValue();
                })
            };

            actions.ForEach(SetValue);
            return actionParameters;
        }

        public static BenchPress EnterBenchPressParameters()
        {
            var actionParameters = new BenchPress();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Количество подходов: (>0) ");
                    actionParameters.Iteration= EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    actionParameters.Time = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Вес человека, кг: (>0) ");
                    actionParameters.WeightPerson = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Вес гири, кг: (>0) ");
                    actionParameters.DistanceOrWeight = EnterDoubleValue();
                })
            };

            actions.ForEach(SetValue);
            return actionParameters;
        }

        public static Swimming EnterSwimmingParameters()
        {
            var actionParameters = new Swimming();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Стиль плавания:\n" +
                    $"1 - Медленный брасс\n" +
                    $"2 - Медленный кроль\n" +
                    $"3 - Быстрый кроль\n");
                    actionParameters.Kkal= ChooseSwimmingStyle();
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: (>0) ");
                    actionParameters.Time = EnterDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Расстояние, м: (>0) ");
                    actionParameters.DistanceOrWeight = EnterDoubleValue();
                }),

                  new Action(() =>
                {
                    Console.Write($"Вес человека, кг: (>0) ");
                    actionParameters.WeightPerson = EnterDoubleValue();
                })
            };

            actions.ForEach(SetValue);
            return actionParameters;
        }

        private static double EnterDoubleValue()
        {
            var buffer = double.Parse(Console.ReadLine().Replace('.', ','));

            return buffer;
        }

        private static double ChooseSwimmingStyle()
        {
            var style = int.Parse(Console.ReadLine());
            var kkal = 6;
            switch (style)
            {
                case 1:
                    kkal = 6;
                    break;
                case 2:
                    kkal = 7;
                    break;
                case 3:
                    kkal = 8;
                    break;
            }
            return kkal;
        }

        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException
                        || exception is FormatException
                        || exception is InvalidOperationException)
                    {
                        Console.WriteLine($"\n{exception.Message}\n");
                    }

                }
            }
        }
    }
}
