using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /*Анисимов. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, number;
            string numbers = null;

            Console.WriteLine("Введите любые числа: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number != 0)
                    {
                        if (number % 2 != 0 && number > 0)
                        {
                            sum += number;
                            if (numbers != null)
                            {
                                numbers = numbers + ", " + number.ToString();
                            }
                            else
                            {
                                numbers = number.ToString();
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    //Console.WriteLine("Введён недопустимый символ, попробуйте ещё раз!"); // a)
                    throw new ApplicationException("Введён недопустимый символ!"); //  б))
                }
            }
           Console.WriteLine($"Введённые нечётные положительные числа: {numbers}");
           Console.WriteLine($"Сумма всех нечётных положительных чисел равна {sum}");
           Console.ReadLine();    
        }
    }
}
