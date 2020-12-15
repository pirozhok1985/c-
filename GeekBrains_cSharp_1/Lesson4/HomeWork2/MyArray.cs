using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork2
{
    class MyArray
    {
        private int[] arr;
        private int length;
        private int startValue;
        private int step;
        private int sum;
        private int maxCount;

        //Индексатор
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        //свойство Sum
        public int Sum
        {
            get
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }

        //Свойство MaxCount
        public int MaxCount
        {
            get 
            {
                Array.Sort(arr);
                int max = arr[arr.Length - 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max)
                        maxCount++;
                }
                return maxCount;
            }
        }

        //Свойство Length
        public int Length { get=>arr.Length;}

        //Свойство GetArray

        public ref int[] GetArray
        {
            get 
            {
                return ref arr;
            }
        }

        //Конструктор 1
        public MyArray(int length, int sVal, int stp)
        {
            arr = new int[length];
            arr[0] = sVal;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + stp;
            }
        }
        //Конструктор 2
        public MyArray(int length)
        {
            arr = new int[length];
        }

        //Конструктор 3
        public MyArray(string fileName)
        {
            string[] ar = File.ReadAllLines(fileName);
            arr = new int[ar.Length];
            for (int i = 0; i < ar.Length; i++) 
            {
                int.TryParse(ar[i], out arr[i]);
            }
        }
        //Метод Inverse
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -1;
            }
        }

        //Метод записи массива в файл
        public static void WriteToFile(MyArray item, String filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            for (int i = 0; i < item.Length; i++)
            {
                sw.WriteLine(item[i]);
            }
            sw.Close();
        }

        //Метод Multi

        public void Multi(int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= val;
            }
        }

        //Метод Merge
        public static MyArray Merge(MyArray arr1, MyArray arr2)
        {
            int newlength = arr1.Length + arr2.Length;
            MyArray newArr = new MyArray(newlength);
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
            }
            int l = arr1.Length;
            for (int j = 0; j < arr2.Length; j++)
            {
                newArr[l] = arr2[j];
                l++;
            }
            return newArr;
        }

        //Метод Copy
        public static void Copy(MyArray arr1, ref MyArray arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        //Метод Resize

        public static void Resize(ref MyArray item, int length)
        {
            MyArray tmp = new MyArray(item.Length);
            MyArray.Copy(item, ref tmp);

            item = new MyArray(length);
            MyArray.Copy(tmp, ref item);
        }

    }
}
