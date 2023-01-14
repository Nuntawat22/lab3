using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Student
    {
        public String name;
        public String id;
        public int brithday;
        public String height;
        public int grade;
        public string major;

        public Student(String name, String id, int brithday, String height, int grade, string major)
        {
            this.name = name;
            this.id = id;
            this.brithday = brithday;
            this.height = height;
            this.grade = grade;
            this.major = major;
        }
        public string n1
        {
            get { return name; }
        }
        public string n2
        {
            get { return id; }
        }
        public int n3
        {
            get { return brithday; }
        }
        public string n4
        {
            get { return height; }
        }
        public int n5
        {
            get { return grade; }
        }
        public string n6
        {
            get { return major; }
        }
    }
}
