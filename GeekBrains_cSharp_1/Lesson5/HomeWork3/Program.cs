using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /*Анисимов. Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.*/
    class Program
    {
        //а)
        static bool isTheSameString1(string s1, string s2)
        {
           
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            s1 = string.Join("",arr1);
            s2 = string.Join("", arr2);
            if (StringComparer.OrdinalIgnoreCase.Equals(s1, s2))
                return true;
            else
                return false;
        }
        //б)
        static bool isTheSameString2(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                char tmp;
                char[] arr1 = new char[s1.Length];
                char[] arr2 = new char[s2.Length];

                for (int i = 0; i < s1.Length; i++) 
                {
                    arr1[i] = s1[i];
                    arr2[i] = s2[i];
                }
                //Bubble Sort
                for (int i = 0; i < arr1.Length - 1; i++) 
                {
                    for (int j = 0; j < arr1.Length - 1; j++) 
                    {
                        if (arr1[j] > arr1[j + 1])
                        {
                            tmp = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = tmp;
                        }
                        if (arr2[j] > arr2[j + 1])
                        {
                            tmp = arr2[j];
                            arr2[j] = arr2[j + 1];
                            arr2[j + 1] = tmp;
                        }
                    }//second 'for' loop
                }//first 'for' loop
                for (int i = 0; i < arr1.Length; i++) 
                {
                    if (arr1[i] == arr2[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s1 = "acdbdcd";
            string s2 = "cdcdbad";
            Console.WriteLine("Результат сравнения строк 1-м способом: {0}",isTheSameString1(s1,s2));
            Console.WriteLine("Результат сравнения строк 2-м способом: {0}", isTheSameString2(s1, s2));
            Console.ReadLine();
        }
    }
}
