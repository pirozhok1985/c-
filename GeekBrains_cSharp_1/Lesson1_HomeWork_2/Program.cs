using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork_2
{
    class Program
    {
        /*
         Анисимов
         Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
         */
        static void Main(string[] args)
        {
            double h, m, I;
            Console.Write("Укажите ваш рост в метрах: ");
            h = double.Parse(Console.ReadLine());

            Console.Write("Укажите ваш вес: ");
            m = double.Parse(Console.ReadLine());

            I = m / (h * h);

            Console.WriteLine("Ваш индекс массы тела: {0:f3}",I);
            Console.ReadLine();
        }
    }
}
