using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    /*Анисимов. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.*/
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[20];
            Random rand = new Random();

            Console.WriteLine("Заполненный массив :");
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = rand.Next(-10000,10000);
                Console.WriteLine(arr[i]);
            }

            for (int j = 0; j < arr.Length - 1; j+=2) 
            {
                if (arr[j] % 3 == 0 || arr[j + 1] % 3 == 0) 
                {
                    count++;
                }
            }
            Console.WriteLine("Количество пар элементов, делящихся на '3' равно {0}",count);
            Console.ReadLine();
        }
    }
}
