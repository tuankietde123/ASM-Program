using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Course
    {
        public string CourseName { get; set; }
        public Teacher CourseTeacher { get; set; }

        public Course(string courseName, Teacher courseTeacher)
        {
            CourseName = courseName;
            CourseTeacher = courseTeacher;
        }
    }
}
