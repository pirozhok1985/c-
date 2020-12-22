using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    /*Анисимов.
     Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).*/
    public delegate double Fun1(double x);
    public delegate double Fun2(double x, double a);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun1 F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        //Перегружаем Table для использования делегата Fun2
        public static void Table(Fun2 F, double x, double b, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        public static double MyFunc1(double x, double a)
        {
            return a * Math.Pow(x,2);
        }
        public static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun1(MyFunc), -2, 2);
            
           
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.            
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(MyFunc2, -2, 2, 4);
            Console.WriteLine("Таблица функции x^2:");
            Table(new Fun2(MyFunc1), -2, 2, 3);
            Console.ReadLine();
        }
    }
}