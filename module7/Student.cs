using System.Collections.Generic;

namespace module7 {
    public class Student {
        public static int students = 0;
        public string FirstName {get; set;}
        private Stack<int> grades;
        public string LastName {get; set;}
        public string City {get; set;}
        public Student() {
            students++;
            grades = new Stack<int>(5);
        }
        public void addGrades() {
            grades.Push(89);
            grades.Push(95);
            grades.Push(78);
            grades.Push(88);
            grades.Push(97);
        }
        public Stack<int> getGrades() {
            return grades;
        }
    }
}
