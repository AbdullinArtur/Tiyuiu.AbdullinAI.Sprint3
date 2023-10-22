using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint3.Task2.V24.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Оператор цикла do-while                                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while                            *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле, при a=0,25              *");
            Console.WriteLine("*                                                                         *");
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.25;
            int start = 1;
            int stop = 8;

            Console.WriteLine("Значение a = " + a);
            Console.WriteLine($"Старт шага  = {start}");
            Console.WriteLine("Конец шага  = {0}", stop);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(a, start, stop);
            Console.WriteLine($"Результат: {res}");
            Console.ReadKey();
        }
    }
}
