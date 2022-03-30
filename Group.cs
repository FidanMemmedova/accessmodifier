using System;
using System.Collections.Generic;
using System.Text;

namespace _29march
{
    class Group : Student
    {
        public string _Name { get; set; }
        public int MaxStuCount { get; set; }
        public Student[] Students { get; set; }
        public Group(string name, int maxStuCount, params Student[] students)
        {
            _Name = name;
            MaxStuCount = maxStuCount;
            Students = students;
        }
        public void addStudent(Student student, Group group)
        {
            if (MaxStuCount < Students.Length + 1)
            {
                Console.WriteLine("The group is full.");
            }
            Console.WriteLine($"{student.Name} {student.Surname} was added to {group._Name}");
            Student[] Students1 = new Student[Students.Length + 1];
            Students1[Students1.Length - 1] = student;
            for (int i = 0; i < Students.Length; i++)
            {
                Students1[i] = Students[i];
            }
        }
        public void RemoveStudent(Student student, Group group)
        {
            if (MaxStuCount <= 0)
            {
                Console.WriteLine("The group is empty.");

            }
            Console.WriteLine($"{student.Name} {student.Surname} was removed from {group._Name}");
            Student[] Students1 = new Student[Students.Length];

            for (int i = 0; i < Students.Length; i++)
            {
                if (student == Students[i])
                {
                    continue;
                }
                else
                {
                    Students1[i] = Students[i];
                }


            }
        }
    }

}