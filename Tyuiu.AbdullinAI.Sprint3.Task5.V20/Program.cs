using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint3.Task5.V20.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда  x = 5                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            Console.WriteLine($"Переменная x = {x}\n");

            int start = 1;
            int start2 = 1;
            int stop = 3;
            int stop2 = 6;

            Console.WriteLine($"старт шага первой суммы ряда = {start}\n");
            Console.WriteLine($"конец шага первой суммы ряда = {stop}\n");
            Console.WriteLine($"старт шага второй суммы ряда = {start2}\n");
            Console.WriteLine($"конец шага второй суммы ряда = {stop2}\n");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSumSeries(x, start, start2, stop, stop2);
            Console.WriteLine("СУММА РЯДА =  " + res);
            Console.ReadKey();
        }
    }
}
