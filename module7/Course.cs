using System.Collections.Generic;
using System;

/*
 * Arraylist deprecated on mac osX http://stackoverflow.com/questions/38323824/unable-to-declare-an-arraylist-using-code-on-osx
 * Microsoft also says to use List<Student> instead for ArrayList because it's typesafe. Looks like when the course was designed,
 * ArrayList was still being used and not deprecated
 */

namespace module7 {
    public class Course {
        private List<Student> students;
        
        public Course() {
            students = new List<Student>();
        }
        public void addStudent(Student student) {
            students.Add(student);
        }
        public List<Student> getStudents() {
            return students;
        }
        public void ListStudents() {
            foreach(Student student in students) {
                Console.WriteLine("First Name, {0} Last Name, {1}", student.FirstName,
                student.LastName);
            }
        }
        public Teacher[] TAs {get; set;}
        public string CourseName {get; set;}
        public int NumberOfStudents {get; set;}
        public Teacher TaughtBy {get; set;}
    }
}