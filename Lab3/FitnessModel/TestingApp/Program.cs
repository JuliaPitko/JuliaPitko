﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessModel;

namespace TestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите тип движения:\n" +
                $"1 - бег\n" +
                $"2 - плавание\n" +
                $"3 - жим штанги\n");

                var action = ChooseActionsType();
                Console.WriteLine("Ответ: " + action.KkalCalculation());
            }
        }

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
                                Console.WriteLine("Введите параметры: ");
                                return ConsoleLoader.EnterRunParameters();
                            }

                        case 2:
                            {
                                Console.WriteLine("Введите параметры: ");
                                return ConsoleLoader.EnterSwimmingParameters();
                            }

                        case 3:
                            {
                                Console.WriteLine("Введите параметры: ");
                                return ConsoleLoader.EnterBenchPressParameters();
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
