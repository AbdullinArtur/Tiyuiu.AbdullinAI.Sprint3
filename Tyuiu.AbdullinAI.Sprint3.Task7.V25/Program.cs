using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint3.Task7.V25.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать прогрумму, которая выыводит таблицу значение функции:          *");
            Console.WriteLine("* F(x) = cos(x) + 4x/2 - sin(x) * 3x (произвести табулирование) на        *");
            Console.WriteLine("* на заданном диапазоне [-5;5] с шагом 1. При делении на ноль вернуть 0.  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");

            int len = ds.GetMassFunction(start, stop).Length;
            double[] valueArray = new double[len];

            valueArray = ds.GetMassFunction(start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("+|   X    |+|  f(x)  |+");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0, 5:d}     |  {1, 5:f2}   |", start, valueArray[i]); // {0,5:d} - выводим start, 5 - 5 отступов, d - decimal
                start++;                                     // {1,5:f2} - выводим valueArray[i], 5 - 5 отступов, f - float, 2 - округляем до двух
                start++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
