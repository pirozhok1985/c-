using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork3
{
    class Program
    {
        /*Анисимов. Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).*/
        static void serializer(List<Student> obj, string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Student>));
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            ser.Serialize(file, obj);
            file.Close();
        }
        static List<Student> StudentsFromCsv(string csvFileName)
        {
            FileStream fs = new FileStream(csvFileName, FileMode.Open, FileAccess.Read);

            List<Student> studentList = new List<Student>();
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                studentList.Add(new Student(line.Split(';')[0], line.Split(';')[1], line.Split(';')[2], line.Split(';')[3], line.Split(';')[4], int.Parse(line.Split(';')[5]), int.Parse(line.Split(';')[6]), int.Parse(line.Split(';')[7]), line.Split(';')[8]));
            }
            fs.Close();
            sr.Close();
            return studentList;
        }
        static void Main(string[] args)
        {
            List<Student> myStudentList = StudentsFromCsv("students_1.csv");
            serializer(myStudentList, "students_1.xml");
        }
    }
}
