using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HomeWork
{
    class Program
    {
        /*
         Анисимов
         Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
         а) используя склеивание;
         б) используя форматированный вывод;
         в) *используя вывод со знаком $.
         */
        static void Main(string[] args)
        {
            string name, sname, height, weight, age;

            Console.Write("Укажите ваше имя: ");
            name = Console.ReadLine();

            Console.Write("Укажите вашу фамилию: ");
            sname = Console.ReadLine();

            Console.Write("Укажите ваш рост: ");
            height = Console.ReadLine();

            Console.Write("Укажите ваш вес: ");
            weight = Console.ReadLine();

            Console.Write("Укажите ваш возраст: ");
            age = Console.ReadLine();

            //а склеивание
            string concat = "Ваше имя: " + name + ", " + "фамилия: " + sname + ", " + "возраст: " + age + ", " + "рост: " + height + ", " + "вес: " + weight;
            Console.WriteLine(concat);
        
            //б форматированный вывод
            Console.WriteLine("Ваше имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}",name,sname,age,height,weight);

            //в интерполяция строк
            Console.WriteLine($"Ваше имя: {name}, фамилия: {sname}, возраст: {age}, рост: {height}, вес: {weight}");
            Console.ReadLine();
        }
    }
}
