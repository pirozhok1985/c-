using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /* Анисимов. Написать метод подсчета количества цифр числа.*/
    class Program
    {
        static int numberCount(int x) 
        {
            int iter = 1;
            while (x / 10 != 0)
            {
                iter++;
                x /= 10;
            }
            return iter;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе {num} равно {numberCount(num)}");
            Console.ReadLine();
        }
    }
}
