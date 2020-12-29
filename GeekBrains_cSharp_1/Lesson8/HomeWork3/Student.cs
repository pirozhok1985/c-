using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Sname { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }

        public Student(string _name, string _sname, string _university, string _faculty, string _department, int _age, int _cource, int _group, string _city)
        {
            Name = _name;
            Sname = _sname;
            University = _university;
            Faculty = _faculty;
            Department = _department;
            Age = _age;
            Course = _cource;
            Group = _group;
            City = _city;
        }
        public Student(){}

    }
}
