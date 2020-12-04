using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    /*Анисимов.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/
    class Program
    {
        static int range(int a, int b, int sum = 0)
        {
            if (a < b)
            {
                Console.Write("{0}, ", a);
                sum += a;
                return range(a + 1,b,sum);
            }
            else
            {
                Console.WriteLine(a);
                sum += a;
                Console.WriteLine("Сумма чисел от a до b равна {0}", sum);
                return a;
            }
        }
        static void Main(string[] args)
        {
            range(100,110);

            Console.ReadLine();
        }
    }
}
