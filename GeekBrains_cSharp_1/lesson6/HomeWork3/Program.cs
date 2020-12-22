using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /*Анисимов. Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
д) разработать единый метод подсчета количества студентов по различным параметрам
выбора с помощью делегата и методов предикатов.*/
    class Program
    {
       public static int SortAge(Student s1, Student s2)
        {
            if (s1.Age > s2.Age)
                return 1;
            if (s1.Age < s2.Age)
                return -1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int count1 = 0; // количество студентов учащихся на 5 и 6 курсах
            int count2 = 0; // количество студентов определённого возраста на каких курсах
            FileStream fs = new FileStream("students_1.csv", FileMode.Open, FileAccess.Read);
 
                List<Student> studentList = new List<Student>();
                StreamReader sr = new StreamReader(fs);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    studentList.Add(new Student(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], int.Parse(line.Split(';')[5]), int.Parse(line.Split(';')[6]), int.Parse(line.Split(';')[7]), line.Split(';')[8]));
                }
                fs.Close();
                sr.Close();

            Dictionary<int, int> fDictionary = new Dictionary<int, int>();
            foreach (var el in studentList)
            {
                if (el.Course == 5 || el.Course == 6)
                    count1++;
            }

            for (int i = 1; i <= 6; i++)
            {
                foreach (var el in studentList)
                {
                    if (el.Age >= 18 && el.Age <= 20 && el.Course == i)
                    {
                        count2++;
                    }
                }
                fDictionary.Add(i, count2);
                count2 = 0;
            }

            Console.WriteLine("количество студентов учащихся на 5 и 6 курсах: {0}", count1);
            Console.WriteLine("Количество студентов в возрасте от 18 до 20\nна 1-м курсе: {0}\nна 2-м курсе: {1}\nна 3-м курсе: {2}\nна 4-м курсе: {3}\nна 5-м курсе: {4}\nна 6-м курсе: {5}",fDictionary[1],fDictionary[2],fDictionary[3],fDictionary[4],fDictionary[5],fDictionary[6]);
            studentList.Sort(SortAge);
            List<Student> mySortedList = studentList.OrderBy(el => el.Course).ThenBy(el => el.Age).ToList<Student>();
            Console.WriteLine("Отсортированный по возрасту список студентов: ");
            //foreach (var item in studentList)
            //{
            //    Console.WriteLine("Имя: {0}, Фамилия: {1}, курс: {2}, возраст: {3}", item.Name, item.Sname, item.Course, item.Age);
            //}

            Console.WriteLine("Отсортированный по курсу возрасту список студентов: ");
            foreach (var item in mySortedList)
            {
                Console.WriteLine("Имя: {0}, Фамилия: {1}, курс: {2}, возраст: {3}", item.Name, item.Sname, item.Course, item.Age);
            }
            

            //Задание 'Д' уже не успеваю до  дэдлайна сделать, но для себя обязательно решу!

            Console.ReadLine();
            
        }
    }
}
