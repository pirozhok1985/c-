using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    /*Анисимов. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
Дополнительные задачи
в) Обработать возможные исключительные ситуации при работе с файлами.*/
    class Program
    {
        static void Main(string[] args)
        {
            MultiDimArray arr = new MultiDimArray(5, 8);
            arr.MaxNum(out int maxIndexRaw, out int maxIndexColumn);
            arr.Print();
            arr.PrinttoFile("test.txt");
            Console.WriteLine("Сумма всех элементов массива равна: {0}",arr.Sum());
            Console.WriteLine("Сумма всех элементов массива, которые больше 6 равна: {0}", arr.Sum(6));
            Console.WriteLine("Максимальный элемент равен: {0}\nМинимальный элемент равен: {1}",arr.Max,arr.Min);
            Console.WriteLine("Индекс максимального элемента массива равен: [{0},{1}]", maxIndexRaw, maxIndexColumn);

            MultiDimArray arr1 = new MultiDimArray("test.txt");
            arr1.Print();
            Console.ReadLine();
        }
    }
}
