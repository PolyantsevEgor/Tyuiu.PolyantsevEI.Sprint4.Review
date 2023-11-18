using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PolyantsevEI.Sprint4.TaskReview.V17.Lib;

namespace Tyuiu.PolyantsevEI.Sprint4.TaskReview.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Полянцев Е. И. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринтуФайл             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Полянцев Егор Ильич | ИСТНб-23-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 4 на 2 и   *");
            Console.WriteLine("* подсчитайте количество четных чисел в матрице.                          *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 3;
            string text = "753159864";
            Console.WriteLine("n: " + n);
            Console.WriteLine("m: " + m);
            Console.WriteLine("String: " + text);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, text);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
