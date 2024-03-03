using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
        }
    }
}
