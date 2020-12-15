using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /*Анисимов. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.*/
    struct account
    {
        public string Login { get; }
        public string Password { get; }

        public account(string l, string p)
        {
            Login = l;
            Password = p;
        }

    }
    class Program
    {
        static bool authCheck(string login, string pass, account item)
        { 
            return (StringComparer.OrdinalIgnoreCase.Equals(login, item.Login) && StringComparer.Ordinal.Equals(pass, item.Password));  
        }
        static void Main(string[] args)
        {
            account auth = new account("root", "GeekBrains");
            string[] arr = System.IO.File.ReadAllLines("test.txt");
            foreach(string el in arr)
            {
                string login = (el.Split(' ')[0]).Split('=')[1];
                string password = (el.Split(' ')[1]).Split('=')[1];

                Console.WriteLine("Имя пользователя: {0}, пароль: {1}",login,password);
                if (authCheck(login, password, auth))
                {
                    Console.WriteLine("Authentication succeded!!");
                    break;
                }
                else
                    Console.WriteLine("Authentication failed! Trying next auth pair from array");
            }
            Console.ReadLine();
        }
    }
}
