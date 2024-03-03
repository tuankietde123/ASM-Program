using System;
using System.Collections.Generic;

namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. List Students");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. List Courses");
                Console.WriteLine("5. Add Subject");
                Console.WriteLine("6. List Subjects");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter student ID: ");
                        int studentId = int.Parse(Console.ReadLine());

                        Student student = new Student(name, age, studentId);
                        studentManager.AddStudent(student);
                        Console.WriteLine("Student added successfully!");
                        break;

                    case "2":
                        List<Student> students = studentManager.GetStudents();
                        Console.WriteLine("Student List:");
                        foreach (Student s in students)
                        {
                            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, ID: {s.StudentId}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter course name: ");
                        string courseName = Console.ReadLine();
                        Console.Write("Enter teacher name: ");
                        string teacherName = Console.ReadLine();
                        Console.Write("Enter teacher age: ");
                        int teacherAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter teacher department: ");
                        string teacherDepartment = Console.ReadLine();

                        Teacher teacher = new Teacher(teacherName, teacherAge, teacherDepartment);
                        Course course = new Course(courseName, teacher);
                        studentManager.AddCourse(course);
                        Console.WriteLine("Course added successfully!");
                        break;

                    case "4":
                        List<Course> courses = studentManager.GetCourses();
                        Console.WriteLine("Course List:");
                        foreach (Course c in courses)
                        {
                            Console.WriteLine($"Course Name: {c.CourseName}");
                            Console.WriteLine($"Teacher: {c.CourseTeacher.Name}");
                            Console.WriteLine($"Department: {c.CourseTeacher.Department}");
                            Console.WriteLine();
                        }
                        break;

                    case "5":
                        Console.Write("Enter subject name: ");
                        string subjectName = Console.ReadLine();
                        Console.Write("Enter teacher name: ");
                        string subjectTeacherName = Console.ReadLine();
                        Console.Write("Enter teacher age: ");
                        int subjectTeacherAge = int.Parse(Console.ReadLine());
                        Console.Write("Enter teacher department: ");
                        string subjectTeacherDepartment = Console.ReadLine();
                        Console.Write("Enter credit hours: ");
                        int creditHours = int.Parse(Console.ReadLine());
                        Console.Write("Enter description: ");
                        string description = Console.ReadLine();
                        Console.Write("Is elective (true/false): ");
                        bool isElective = bool.Parse(Console.ReadLine());

                        Teacher subjectTeacher = new Teacher(subjectTeacherName, subjectTeacherAge, subjectTeacherDepartment);
                        Subject subject = new Subject(subjectName, subjectTeacher, creditHours, description, isElective);
                        studentManager.AddSubject(subject);
                        Console.WriteLine("Subject added successfully!");
                        break;

                    case "6":
                        List<Subject> subjects = studentManager.GetSubjects();
                        Console.WriteLine("Subject List:");
                        foreach (Subject subj in subjects)
                        {
                            Console.WriteLine($"Subject Name: {subj.SubjectName}");
                            Console.WriteLine($"Teacher: {subj.SubjectTeacher.Name}");
                            Console.WriteLine($"Department: {subj.SubjectTeacher.Department}");
                            Console.WriteLine($"Credit Hours: {subj.CreditHours}");
                            Console.WriteLine($"Description: {subj.Description}");
                            Console.WriteLine($"Is Elective: {subj.IsElective}");
                            Console.WriteLine();
                        }
                        break;

                    case "7":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}