using System;
using System.Collections.Generic;

namespace module7 {
    public class Program {
        public static void Main(string[] args) {
            Program prog = new Program();
            List<Student> students = new List<Student>(3);
            Teacher teacher = new Teacher();
            Course course = new Course();
            //Degree degree = new Degree();
            //UProgram program = new UProgram();
            prog.instantiateStudents(students);
            prog.instantiateTeacher(teacher);
            prog.instantiateCourse(course, students, teacher);
            //prog.instantiateDegree(degree, course);
            //prog.instantiateProgram(program, degree);
            course.ListStudents();
        }

        private void instantiateProgram(UProgram program, Degree degree) {
            program.ProgramName = "Information Technology";
            program.Degree = degree;
            program.StartDate = DateTime.Now;
            program.EndDate = DateTime.Parse("09/09/2017");
        }

        private void instantiateDegree(Degree degree, Course course) {
            degree.Course = course;
            degree.DegreeName = "Bachelor of Science";
            degree.EndDate = DateTime.Parse("09/09/17");
            degree.StartDate = DateTime.Now;
        }

        private void instantiateTeacher(Teacher teacher) {
            teacher.FirstName = "Teacher";
            teacher.LastName = "Test";
            teacher.CourseTaught = "Programming with C#";
        }

        private void instantiateCourse(Course course, List<Student> students, Teacher teacher) {
            course.CourseName = "Programming with C#";
            course.NumberOfStudents = 30;
            course.TaughtBy = teacher;
            foreach(Student student in students) {
                course.addStudent(student);
            }
        }

        private void instantiateStudents(List<Student> students) {
            Student student0 = new Student();
            student0.FirstName = "Test";
            student0.LastName = "Student";
            student0.City = "Boston";
            student0.addGrades();
            students.Add(student0);
            
            Student student1 = new Student();
            student1.FirstName = "Test1";
            student1.LastName = "Student1";
            student1.City = "Boston1";
            student1.addGrades();
            students.Add(student1);

            Student student2 = new Student();
            student2.FirstName = "Test2";
            student2.LastName = "Student2";
            student2.City = "Boston2";
            student2.addGrades();
            students.Add(student2);
        }
    }
}