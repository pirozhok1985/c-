using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /*Анисимов. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите желаемое количество чисел. Ввод завершится, если будет набран 0");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0) break;
                if (number % 2 != 0 && number > 0)
                    sum += number;  
            }
            Console.WriteLine($"Сумма всех нечётных положительных чисел равна {sum}");
            Console.ReadLine();
        }
    }
}
