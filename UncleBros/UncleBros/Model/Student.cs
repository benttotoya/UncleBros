using System;
using System.Collections.Generic;
using System.Text;

namespace UncleBros.Model
{
    public class Student
    {
        int id;
        string name;
        string major;
        char gender;
        string grade;
        int age;

        public Student(int id, string name, string major, char gender, string grade, int age)
        {
            Id = id;
            Name = name;
            Major = major;
            Gender = gender;
            Grade = grade;
            Age = age;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
