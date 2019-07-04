using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Sergeevi.Modals
{
    public class Student
    {
        private int id;
        private string name;

        public Student() { }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }

    public class Subject
    {
        private int id;
        private string name;

        public Subject() { }

        public Subject(string name)
        {
            this.name = name;
        }

        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

    }

    public class Grades
    {
        private int id;
        private int studentId;
        private int subjectId;
        private int grade;
        public Student student;
        public Subject subject;

        public Grades() { }

        public Grades(Student student, Subject subject, int grade)
        {
            this.grade = grade;
            this.studentId = student.Id;
            this.subjectId = subject.Id;
        }

        public int Id { get => id; set => id = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int SubjectId { get => subjectId; set => subjectId = value; }
        public int Grade { get => grade; set => grade = value; }
    }
}
