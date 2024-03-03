using System.Collections.Generic;

public class Subject
{
    // các thuộc tính và phương thức khác của Subject
}

namespace StudentManagement
{
    public class StudentManager
    {
        private List<Student> students;
        private List<Course> courses;
        private List<Subject> subjects;

        public StudentManager()
        {
            students = new List<Student>();
            courses = new List<Course>();
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public List<Subject> GetSubjects()
        {
            return subjects;
        }
    }
}

