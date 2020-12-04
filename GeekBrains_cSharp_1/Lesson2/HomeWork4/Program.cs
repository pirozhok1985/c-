using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    /*Анисимов. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.*/
    class Program
    {
        static bool authCheck(string login, string pass)
        {
            return (StringComparer.OrdinalIgnoreCase.Equals(login, "root") && StringComparer.Ordinal.Equals(pass, "GeekBrains"));
        }
        static void Main(string[] args)
        {
            int count = 1;
            bool authResult = false;
            Console.WriteLine("Введите имя пользователя:");
            string loginName = Console.ReadLine();
            do
            {
                count++;
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                if (authCheck(loginName, password))
                {
                    Console.WriteLine("Authentication succeded!!");
                    authResult = true;
                    break;
                }
                else
                    Console.WriteLine("Authentication failed!");
            } while (count <= 3);
            if(count != 3 && authResult == false)
                Console.WriteLine("Number of authentication tries has been exceeded");
            Console.ReadLine();
        }
    }
}
