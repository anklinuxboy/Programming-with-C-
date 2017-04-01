using System;

namespace module6 {
    public class Program {
        public static void Main(string[] args) {
            Program prog = new Program();
            Student[] students = new Student[3];
            Teacher teacher = new Teacher();
            Course course = new Course();
            Degree degree = new Degree();
            UProgram program = new UProgram();
            prog.instantiateStudents(students);
            prog.instantiateTeacher(teacher);
            prog.instantiateCourse(course, students, teacher);
            prog.instantiateDegree(degree, course);
            prog.instantiateProgram(program, degree);
            Console.WriteLine("The {0} program contains the {1} degree", 
            program.ProgramName, program.Degree.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}",
            program.Degree.DegreeName, program.Degree.Course.CourseName);
            Console.WriteLine("The {0} course contains {1} students",
            program.Degree.Course.CourseName, Student.students);
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

        private void instantiateCourse(Course course, Student[] students, Teacher teacher) {
            course.CourseName = "Programming with C#";
            course.NumberOfStudents = 30;
            course.Students = students;
            course.TaughtBy = teacher;

        }

        private void instantiateStudents(Student[] students) {
            for (int i = 0; i < students.Length; i++) {
                students[i] = new Student();
            }
            students[0].FirstName = "Test";
            students[0].LastName = "Student";
            students[0].City = "Boston";
            Person person = students[0];
            students[1].FirstName = "Test1";
            students[1].LastName = "Student1";
            students[1].City = "Boston1";
            students[2].FirstName = "Test2";
            students[2].LastName = "Student2";
            students[2].City = "Boston2";
        }
    }
}