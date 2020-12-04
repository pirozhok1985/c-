using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    /*
     Анисимов
     Написать метод, возвращающий минимальное из трёх чисел
     */
    
    class Program
    {
        static int minVal(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа для сравнения : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальное число : {minVal(x,y,z)}");
            Console.ReadLine();
        }
    }
}
