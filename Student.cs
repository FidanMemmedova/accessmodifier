using System;
using System.Collections.Generic;
using System.Text;

namespace _29march
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Profession { get; set; }
        public Student()
        {

        }
        public Student(string id, string name, string surname, string profession)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Profession = profession;

        }
    }
}
