using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeWork1
{
    /*Анисимов. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин для проверки: ");
            string login = Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////a
            string permitedLetters = "ABCDEFGHIJKLMNOPQRSTUVWXUZabcdefghijklmnopqrstuvwxuz";
            string numbers = "1234567890";
            bool isGood = true;

            if (login.Length >= 2 && login.Length <= 10 && !numbers.Contains(login[0].ToString()))
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (permitedLetters.Contains(login[i].ToString()) || numbers.Contains(login[i].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        isGood = false;
                        break;
                    }
                }
            }
            else
            {
                isGood = false;
            }
            if (isGood)
            {
                Console.WriteLine("Ваш логин соответсвует всем требованиям");
            }
            else
            {
                Console.WriteLine("Ваш логин не соответсвует всем требованиям");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////b

            string pattern = @"^[a-zA-z][a-zA-Z0-9]{1,9}$";
            Regex expr = new Regex(pattern);
            if (expr.IsMatch(login))
            {
                Console.WriteLine("Ваш логин соответсвует всем требованиям");
            }
            else
            {
                Console.WriteLine("Ваш логин не соответсвует всем требованиям");
            }
            Console.ReadLine();
        }
    }
}
