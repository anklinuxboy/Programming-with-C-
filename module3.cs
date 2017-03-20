using System;

namespace ConsoleApplication
{
public class Program
{
    /* I have included the code for Student, Teacher and Course. The code for program and degree is very similar to what I've written so did not 
    include it. I've included the answer to the challenge question */
    /* Student Details */
    static void getStudentDetails() {
        Console.WriteLine("Enter student's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter student's last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter student's date of birth in MM/DD/YYYY");
        DateTime birthDate = DateTime.MinValue;
        string date = Console.ReadLine();
        try {
        birthDate = DateTime.Parse(date);
        } catch(FormatException) {
        Console.WriteLine("Date not entered in correct format");
        }

        printStudentDetails(firstName, lastName, birthDate);
    }
    // to solve the challenge, we can use the TryParse() method on DateTime object to see if the user entered the correct format
    // if not, we can ask the user to enter the value again
    static void printStudentDetails(string firstName, string lastName, DateTime birthDate) {
        if (!birthDate.Equals(DateTime.MinValue)) {
        Console.WriteLine("First name: {0} Last name: {1} birthDate {2}", firstName, lastName, birthDate.ToString());
        } else {
        Console.WriteLine("First name: {0} Last name: {1} Incorrect Birth date", firstName, lastName);
        }
    }

    /* Teacher Details */
    static void getTeacherDetails() {
        Console.WriteLine("Enter teachers's first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter teachers's last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter teachers's date of birth in MM/DD/YYYY");
        DateTime birthDate = DateTime.MinValue;
        string date = Console.ReadLine();
        try {
        birthDate = DateTime.Parse(date);
        } catch(FormatException) {
        Console.WriteLine("Date not entered in correct format");
        }

        printTeacherDetails(firstName, lastName, birthDate);
    }
    // to solve the challenge, we can use the TryParse() method on DateTime object to see if the user entered the correct format
    // if not, we can ask the user to enter the value again
    static void printTeacherDetails(string firstName, string lastName, DateTime birthDate) {
        if (!birthDate.Equals(DateTime.MinValue)) {
        Console.WriteLine("First name: {0} Last name: {1} birthDate {2}", firstName, lastName, birthDate.ToString());
        } else {
        Console.WriteLine("First name: {0} Last name: {1} Incorrect Birth date", firstName, lastName);
        }
    }

    /* Course Details */
    static void getCourseDetails() {
        Console.WriteLine("Enter Course name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Course ID");
        string courseID = Console.ReadLine();
        Console.WriteLine("Enter course start date");
        DateTime startDate = DateTime.MinValue;
        string date = Console.ReadLine();
        try {
        startDate = DateTime.Parse(date);
        } catch(FormatException) {
        Console.WriteLine("Date not entered in correct format");
        }

        printCourseDetails(name, courseID, startDate);
    }
    // to solve the challenge, we can use the TryParse() method on DateTime object to see if the user entered the correct format
    // if not, we can ask the user to enter the value again
    static void printCourseDetails(string name, string courseID, DateTime startDate) {
        if (!startDate.Equals(DateTime.MinValue)) {
        Console.WriteLine("First name: {0} Last name: {1} Course Start Date {2}", name, courseID, startDate.ToString());
        } else {
        Console.WriteLine("First name: {0} Last name: {1} Incorrect Start date", name, courseID);
        }
    }

    static void validateBirthDate() {
        try {
        throw new NotImplementedException("Method not implemented");
        } catch(NotImplementedException e) {
        Console.WriteLine(e.ToString());
        } 
    }
    public static void Main(string[] args)
    {
        // uncomment the methods which you want to run
        //getStudentDetails();
        //getCourseDetails();
        validateBirthDate();
        //getTeacherDetails();
        // uncomment this line if running code on windows.
        //Console.ReadKey();
    }
}
}