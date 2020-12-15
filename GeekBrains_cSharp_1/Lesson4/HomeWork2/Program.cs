using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /*Анисимов. а) Дописать класс MyArray для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов, создать индексирующее свойство, свойство Length, возвращающая длину массива, метод Merge объединяющий два массива в один и возвращающий объединенный массив, метод MyArray Copy(), возвращающий копию массива, метод MyArray Resize(int newSize) изменяющий размер массива, свойство GetArray с помощью которого можно получить ссылку на массив. В Main продемонстрировать работу класса.
б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Инициализируем массив arr");
            MyArray arr = new MyArray(10, 100, 10);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Сумма всех элементов массива равна: {0}", arr.Sum);
            Console.WriteLine("Применяем инверсию");
            arr.Inverse();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Используем метод Multi");
            arr.Multi(10);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Инициализируем массив arr1 и заполняем его рандомными значениями в диапазоне от 10 до 20");
            MyArray arr1 = new MyArray(20);
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(10,20);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("Количество элементов с максимальным значением равно {0}",arr1.MaxCount);

            Console.WriteLine("Используем метод Merge");
            MyArray newArr = MyArray.Merge(arr, arr1);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }

            Console.WriteLine("Инициализируем массив arr2");
            MyArray arr2 = new MyArray(10);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Копируем массив arr в массив arr2");
            MyArray.Copy(arr, ref arr2);
          
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Изменяем размер массива arr2 с 10 на 20");
            MyArray.Resize(ref arr2, 20);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Ссылка на массив arr2: {0}",arr2.GetArray);

            string fileName = @"C:\Users\Pirozhok\Downloads\test.txt";
            MyArray.WriteToFile(arr2, fileName);

            Console.WriteLine("Создадим массив из файла");
            string file = @"C:\Users\Pirozhok\Downloads\test.txt";
            MyArray arr3 = new MyArray(file);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            Console.ReadLine();
        }
    }
}
