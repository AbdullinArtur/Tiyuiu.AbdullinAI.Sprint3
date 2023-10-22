using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint3.Task3.V10.Lib;

namespace Tyuiu.AbdullinAI.Sprint3.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Абудллин А. И.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Абдуллин А. И. | АСОиУБ-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Используя цикл foreach удалить из строки все буквы p в строке: *");
            Console.WriteLine("* gdfppf vfppt p                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string x = "gdfppf vfppt p";
            char y = 'p';
            Console.WriteLine($"исходная строка: {x}");
            Console.WriteLine($"символ который нужно удалить - {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            string res = ds.DeleteCharInString(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
