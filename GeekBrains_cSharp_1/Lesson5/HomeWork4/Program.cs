using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    /*Анисимов. *На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран
фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = System.IO.File.ReadAllLines("ege.txt");
            List<KeyValuePair<string, double>> sortedRes = new List<KeyValuePair<string, double>>();         
            List<KeyValuePair<string, double>> worst_3 = new List<KeyValuePair<string, double>>(); //3 худших ученика
            List<KeyValuePair<string, double>> worst = new List<KeyValuePair<string, double>>();
            string s_worst_3 = "";
            string s_worst = "";
            double avarage = 0; //средннее по ученику
            int count = 1;// для вывода 3-х строк с самыми низкими средними баллами

            foreach (var el in arr) 
            {
                avarage = Math.Round((double.Parse(el.Split(' ')[2]) + double.Parse(el.Split(' ')[3]) + double.Parse(el.Split(' ')[4])) / 3,1);
                KeyValuePair<string,double> unit = new KeyValuePair<string, double>(el.Split(' ')[0] + ' ' + el.Split(' ')[1], avarage);

                if (sortedRes.Count == 0)
                {
                    sortedRes.Add(unit);
                }
                else if(sortedRes.Count == 1)
                {
                    for (int i = 0; i < sortedRes.Count; i++)
                    {
                        if (unit.Value > sortedRes[i].Value)
                        {
                            sortedRes.Add(unit);
                            break;
                        }
                        else
                        {
                            sortedRes.Insert(i, unit);
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < sortedRes.Count; i++)
                    {
                        if (i < sortedRes.Count - 1)
                        {
                            if (unit.Value >= sortedRes[i].Value && unit.Value <= sortedRes[i + 1].Value)
                            {
                                sortedRes.Insert(i + 1, unit);
                                break;
                            }
                            else if (unit.Value <= sortedRes[i].Value)
                            {
                                sortedRes.Insert(i, unit);
                                break;
                            }
                        }
                        else if (i == sortedRes.Count - 1)
                        {
                            if (unit.Value > sortedRes[i].Value)
                            {
                                sortedRes.Add(unit);
                                break;
                            }
                            else
                            {
                                sortedRes.Insert(i, unit);
                                break;
                            }
                        }
                    }//end of for
                }//end of first else
            }//end of foreach

            for (int i = 0; i < sortedRes.Count; i++)
            {

                if (worst_3.Count == 0)
                {
                    worst_3.Add(sortedRes[i]);
                    s_worst_3 = sortedRes[i].Key + "\n";
                    count++;
                }

                else if (count <= 3)
                {
                   if (sortedRes[i].Value != sortedRes[i - 1].Value)
                   {
                       worst_3.Add(sortedRes[i]);
                       s_worst_3 += sortedRes[i].Key + "\n";
                       count++;
                   }

                }
            }

            foreach (var el in sortedRes)
            {
                foreach (var e in worst_3)
                {
                    if (el.Value == e.Value && el.Key != e.Key)
                    {
                        worst.Add(el);
                        s_worst += el.Key + "\n";
                    }
                }
            }

            Console.Write("Топ 3 худших балбеса:\n{0}",s_worst_3);
            Console.WriteLine("------------------");
            Console.Write("Друзья худших балбесов:\n{0}", s_worst);
            Console.ReadLine();
        }
    }
}
