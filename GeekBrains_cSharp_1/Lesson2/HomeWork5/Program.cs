using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    /*Анисимов. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
    class Program
    {
        static void Main(string[] args)
        {
            double h, m, I, normI;
            Console.Write("Укажите ваш рост в метрах: ");
            h = double.Parse(Console.ReadLine());

            Console.Write("Укажите ваш вес: ");
            m = double.Parse(Console.ReadLine());

            I = m / (h * h);
            if (I < 18.5)
            {
                normI = 18.5;
                Console.WriteLine("Ваш индекс массы тела: {0:f3}, нужно набрать вес в размере {1:f2} кг", I, m = (m - normI * h * h) * (-1));
            }
            else if (I > 25)
            {
                normI = 25;
                Console.WriteLine("Ваш индекс массы тела: {0:f3}, нужно сбросить вес в размере {1:f2} кг", I, m = m - normI * h * h);
            }
            else
            {
                Console.WriteLine("Ваш индекс массы тела: {0:f3}, вес в норме", I);
            }

            Console.ReadLine();
        }
    }
}
