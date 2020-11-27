using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork_3
{
    class Program
    {
        /*
         Анисимов
         а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
         б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
         */
        static double distPointCount(double x1, double y1, double x2, double y2)
        {
            double r;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, r;
            Console.WriteLine("Введите координату первой точки по оси x: ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату первой точки по оси y: ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату второй точки по оси x: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату второй точки по оси y: ");
            y2 = double.Parse(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между двумя точками координат равно: {0:f2}",r);

            Console.WriteLine("(метод)Расстояние между двумя точками координат равно: {0:f2}", r);
            r = Program.distPointCount(x1, y1, x2, y2);
            Console.ReadLine();
        }
    }
}
