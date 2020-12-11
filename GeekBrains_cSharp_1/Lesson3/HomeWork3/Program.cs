using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
/*Анисимов. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rational val1 = new Rational("2/3");
            //Rational val2 = new Rational("3/5");

            Console.Write("Введите первую дробь: ");
            Rational val1 = new Rational(Console.ReadLine());
            Console.Write("Введите вторую дробь: ");
            Rational val2 = new Rational(Console.ReadLine());

            Console.WriteLine($"Сумма дробей {val1} и {val2} равна {Rational.sum(val1, val2)}");
            Console.WriteLine($"Разность дробей {val1} и {val2} равна {Rational.sub(val1, val2)}");
            Console.WriteLine($"Произведение дробей {val1} и {val2} равно {Rational.multi(val1, val2)}");
            Console.WriteLine($"Частное дробей {val1} и {val2} равно {Rational.div(val1, val2)}");
            Console.ReadLine();
        }
    }
}
