using Lab1.Core;
using Lab1.Kumachev;
using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogInterface logger = KumachevLog.I();
            logger.Log("Program: Ввод 3 параметров");

            if (!float.TryParse(Console.ReadLine(), out float a))
            {
                logger.Log("Введено не число");
                return;
            }

            if (!float.TryParse(Console.ReadLine(), out float b))
            {
                logger.Log("Введено не число");
                return;
            }

            if (!float.TryParse(Console.ReadLine(), out float c))
            {
                logger.Log("Введено не число");
                return;
            }

            logger.Log($"Program: Получено уравнение {a}*x^2 + {b}*x + {c} = 0");
            EquationInterface equation = new QuadraticEquation();

            try
            {
                List<float> roots = equation.Solve(a, b, c);
                string rootsString = string.Join(", ", roots.ToArray());
                logger.Log($"Program: Корни уравнения: {rootsString}");
            }
            catch (KumachevException exception)
            {
                logger.Log(exception.Message);
            }
            finally
            {
                logger.Write();
            }

            Console.ReadKey();
        }
    }
}
