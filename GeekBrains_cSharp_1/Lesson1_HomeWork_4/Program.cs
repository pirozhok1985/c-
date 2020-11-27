using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork_4
{
    class Program
    {
        /*
         Анисимов
         Написать программу обмена значениями двух переменных.
         а) с использованием третьей переменной;
         б) *без использования третьей переменной
        */
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20, tmp;
            Console.WriteLine("До обмена:\na = {0}\nb = {1}",a,b);

            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("После обмена:\na = {0}\nb = {1}", a, b);

            a = 10; b = 20;

            a = a ^ b;
            b = b ^ a;
            a = a ^ b;
            Console.WriteLine("(*)После обмена:\na = {0}\nb = {1}", a, b);
            Console.ReadLine();
        }
    }
}
