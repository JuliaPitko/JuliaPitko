using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace TestingApp
{
    /// <summary>
    /// Ввод параметров расчёта
    /// </summary>
    public static class ConsoleLoader
    {
       /// <summary>
       /// Ввод параметров для бега
       /// </summary>
       /// <returns>параметры</returns>
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
                    Console.Write("Вес человека, кг: " +
                    $"от {ActionsBase.MinWeight} до {ActionsBase.MaxWeight} ");
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

       /// <summary>
       /// Ввод параметров жима лежа
       /// </summary>
       /// <returns>параметры</returns>
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
                     Console.Write($"Вес человека, кг:" +
                     $"от {ActionsBase.MinWeight} до {ActionsBase.MaxWeight} ");
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

        /// <summary>
        /// Ввод параметров плавания
        /// </summary>
        /// <returns>параметры</returns>
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
                    actionParameters.SwimmingEnum = ChooseSwimmingStyle();
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
                    Console.Write($"Вес человека, кг:" +
                     $"от {ActionsBase.MinWeight} до {ActionsBase.MaxWeight} ");
                    actionParameters.WeightPerson = EnterDoubleValue();
                })

            };

            actions.ForEach(SetValue);
            return actionParameters;
        }

       /// <summary>
       /// Ввод дробного числа с консоли
       /// </summary>
       /// <returns>введенное число</returns>
        private static double EnterDoubleValue()
        {
            var buffer = double.Parse(Console.ReadLine().Replace('.', ','));

            return buffer;
        }

        /// <summary>
        /// Ввод типа плавания
        /// </summary>
        /// <returns>калории при данном типе</returns>
        private static SwimmingEnum ChooseSwimmingStyle()
        {
            while (true)
            {
                try
                {

                    int style = int.Parse(Console.ReadLine());
                    switch (style)
                    {
                        case 1:
                        {
                            return SwimmingEnum.SlowBrace;
                        }
                        case 2:
                        {
                            return SwimmingEnum.QuickCrawl;
                        }
                        case 3:
                        {
                            return SwimmingEnum.SlowСrawl;
                        }
                        default:
                        {
                            throw new ArgumentException("Такого стиля нет! Введите повторно");
                        }
                    }

                    return default(SwimmingEnum);
                }
                catch (Exception exception)
                {
                    if (exception is ArgumentException
                        || exception is FormatException)
                    {
                        Console.WriteLine($"\n{exception.Message}\n");
                    }
                }
            }   

        }
        /// <summary>
        /// Задание значения
        /// </summary>
        /// <param name="action">делегат с заданием параметраы</param>
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
