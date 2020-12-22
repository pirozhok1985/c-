using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    /*Анисимов.  Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.*/
    class Program
    {
        public delegate double minF(double x); // создали делегат
        public static void showDelegateInfo(minF item) // Функция просмотра информации о делегате
        {
            if (item.GetInvocationList() != null)
            {
                foreach (var value in item.GetInvocationList())
                {
                    Console.WriteLine("Методы: {0}\nКласс: {1}",value.Method, value.Target);
                }
            }
        }
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * x * x - 3 * x + 1;
        }
        public static void SaveFunc(int fNum, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            Dictionary<int, minF> delegatesList = new Dictionary<int, minF>
            {
                { 1, new minF(F1) },
                { 2, new minF(F2) }
            };
            minF myDelegate = delegatesList[fNum];// объявили переменную-член делегата и добавили туда метод для вызова(функция F)
           // showDelegateInfo(myDelegate); //Посмотрели информацию о делегате
            double x = a;
            while (x <= b)
            {
                bw.Write(myDelegate(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] arr = new double[fs.Length / sizeof(double)];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                arr[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете функцию для нахождения её минимума\n1. y = x * x - 50 * x + 10\n2. y = x * x * x - 3 * x + 1");
            int.TryParse(Console.ReadLine(), out int fNumber);
            Console.Write("Выберете отрезок, на котором будет найден минимум функции\nНачало отрезка: ");
            int.TryParse(Console.ReadLine(), out int start);
            Console.Write("Конец отрезка: ");
            int.TryParse(Console.ReadLine(), out int end);
            SaveFunc(fNumber, "data.bin", start, end, 0.5);
            double[] tmp = Load("data.bin", out double min);
            Console.WriteLine("Минимум функции равен {0}", min);
            Console.ReadKey();
        }
    }
}