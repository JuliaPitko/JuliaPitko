using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace TestingApp
{
    /// <summary>
    /// Тестирующий класс
    /// </summary>
    class Program
    {
        /// <summary>
        /// точка вхождения в программу
        /// </summary>
        /// <param name="args">аргументы</param>
        static void Main(string[] args)
        {
            while (true )
            {
                Console.Write("Выберите тип движения:\n" +
                $"1 - бег\n" +
                $"2 - плавание\n" +
                $"3 - жим штанги\n" +
                $"4 - чтобы выйти\n");

                var action = ChooseActionsType();
                Console.WriteLine("Ответ: " + action.KkalCalculation());
            }
        }

        /// <summary>
        /// Выбор вида спорта
        /// </summary>
        /// <returns></returns>
        private static ActionsBase ChooseActionsType()
        {
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите параметры для бега: ");
                                return ConsoleLoader.EnterRunParameters();
                            }

                        case 2:
                            {
                                Console.WriteLine("Введите параметры для плавания: ");
                                return ConsoleLoader.EnterSwimmingParameters();
                            }

                        case 3:
                            {
                                Console.WriteLine("Введите параметры для жима штанги: ");
                                return ConsoleLoader.EnterBenchPressParameters();
                            }

                        case 4:
                            {
                                Environment.Exit(0);
                                break;
                            }

                        default:
                            {
                                throw new ArgumentException("Такого номера нет! Введите повторно");
                            }
                    }

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
    }
}
