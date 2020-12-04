using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    /*Анисимов. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int goodCount = 0;
            for (int i = 1; i <= 1000000000; i++) 
            {
                int j = i;
                int sum = 0;
                while (j / 10 != 0)
                {
                    sum += j % 10;
                    j /= 10;
                }
                sum += j;
                if (sum != 0 && i % sum == 0)
                {
                    goodCount++;
                }
            }
            DateTime end = DateTime.Now;
            TimeSpan duration = end - start;
            Console.WriteLine($"Количество хороших чисел в диапазоне от 1 до 1000000000 равно: {goodCount}\nВремя выполнения программы составило : {duration.Minutes} мин.");
            Console.ReadLine();
        }
    }
}
