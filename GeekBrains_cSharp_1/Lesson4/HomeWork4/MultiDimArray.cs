using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class MultiDimArray
    {
        private int[,] arr;
        private int raw;
        private int column;
        private int sum;
        private int max;
        private int min;

        public int Min
        {
            get
            {
                min = arr[0, 0];
                for (int i = 0; i < raw; i++)
                {
                    for (int j = 1; j < column; j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                        }
                    }
                }
                return min;
            }
        }

        public int Max
        {
            get
            {
                max = arr[0, 0];
                for (int i = 0; i < raw; i++)
                {
                    for (int j = 1; j < column; j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                return max;
            }
        }

        public MultiDimArray(int r, int c)
        {
            column = c;
            raw = r;
            arr = new int[raw, column];
            Random rand = new Random();
            for (int i = 0; i < raw; i++) 
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i,j] = rand.Next(0, 10);
                }
            }
        }

        public MultiDimArray(string fileName)
        {
            try
            {
                string[] str = System.IO.File.ReadAllLines(fileName);
                raw = str.Length;
                column = str[0].Length;
                arr = new int[raw, column];
                for (int i = 0; i < raw; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        string tmp = (str[i][j]).ToString();
                        arr[i, j] = int.Parse(tmp);
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Файл не найден, проверьте путь");
            }
        }
        public int Sum()
        {
            sum = 0;
            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }
        public int Sum(int element)
        {
            sum = 0;
            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (arr[i, j] > element) 
                    {
                        sum += arr[i, j];
                    }    
                }
            }
            return sum;
        }

        public void MaxNum(out int indexRaw, out int indexColumn)
        {
            indexRaw = 0;
            indexColumn = 0;
            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indexRaw = i;
                        indexColumn = j;
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < raw; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("{0,2}",arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void PrinttoFile(string fileName)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName);
                for (int i = 0; i < raw; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        sw.Write(arr[i, j]);
                    }
                    sw.WriteLine();
                }
                sw.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("Отсутсвует право на запись в данный каталог!!!!");
            }
        }
    }
}
