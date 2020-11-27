using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork_5
{
    class Program
    {
        /*
         Анисимов
         а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         б) Сделать задание, только вывод организуйте в центре экрана
         в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)

         *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
         */

        static void print(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            string name = "Евгений", sename = "Анисимов", city = "Хабаровск";

            //Console.SetCursorPosition(25, 16);
            Console.WriteLine($"Моё имя {name}, моя фамилия {sename} и живу я в городе {city}");

            //*
            string s = $"Моё имя {name}, моя фамилия {sename} и живу я в городе {city}";
            int x = 24;
            int y = 15;
            UsefullMethods.print(s, x, y);
            UsefullMethods.pause();
        }
    }
}
