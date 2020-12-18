using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /*Анисимов. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.*/
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Карл у Клары украл кораллы, а Клара у Карла укралла кларнет.";
            int num = 5;
            char letter = 'а';
            string str;
            string str1;
            string str2;

            char[] dim = { ' ', ',', '.', '!', '?' };
            string[] arr = s.Split(dim, StringSplitOptions.RemoveEmptyEntries);

            Message.DisplayCustomLengthWords(arr, num, out str);
            Message.RemoveCurrentWord(arr, letter, out str1);
            Message.FindMaxWords(arr, out str2); //я объеденил задание в) и г), потому что задание г) включает в себя задание в).
            Console.WriteLine("Исходная строка:\n{0}\n",s);
            Console.WriteLine("Выводим слова, содержащие не более {1} символов:\n{0}\n",str,num);
            Console.WriteLine("Удаляем слова с буквой '{1}' на конце:\n{0}\n",str1,letter);
            Console.WriteLine("Выводим строку с самыми длинными словами:\n{0}",str2);
            Console.ReadLine();
        }
    }
}
