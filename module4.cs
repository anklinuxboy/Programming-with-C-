using System;

public class Struct {
    public struct Student {
        public string firstName;
        public string lastName;
        public string city;
    }

    public struct Teacher {
        public string firstName;
        public string lastName;
        public string city;
    }

    public struct Program {
        public string name;
        public DateTime startDate;
        public string ProgramSize;
    }

    public struct Course {
        public string name;
        public DateTime startDate;
        public string classSize;
    }

    public static void Main(string[] args) {
        Student[] studentArray = new Student[5];
        studentArray[0].firstName = "Test";
        studentArray[0].lastName = "Student";
        studentArray[0].city = "Boston";

        Console.WriteLine("Student First name: {0}, Last name: {1}, City: {2}", 
        studentArray[0].firstName, studentArray[0].lastName, studentArray[0].city);
    }
}