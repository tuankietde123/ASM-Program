using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public Teacher SubjectTeacher { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public bool IsElective { get; set; }

        public Subject(string subjectName, Teacher subjectTeacher, int creditHours, string description, bool isElective)
        {
            SubjectName = subjectName;
            SubjectTeacher = subjectTeacher;
            CreditHours = creditHours;
            Description = description;
            IsElective = isElective;
        }
    }
}
