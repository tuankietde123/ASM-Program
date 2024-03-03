using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Teacher : Person
    {
        public string Department { get; set; }

        public Teacher(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }
    }
}
