using System;

public class Student {
    static void Main(string[] args) {
        string firstName;
        string lastName;
        DateTime birthDate;
        string addressOne;
        string addressTwo;
        string city;
        string state;
        string zipCode;
        string country;
        Console.WriteLine("Enter details for students");
        Console.WriteLine("Enter First Name");
        firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name");
        lastName = Console.ReadLine();

        Console.WriteLine("Enter Birth Date in MM/DD/YYYY format");
        string birthdate = Console.ReadLine();
        while (!DateTime.TryParse(birthdate, out birthDate)) {
        Console.WriteLine("Incorrect date format. Please enter the correct date format");
        birthdate = Console.ReadLine();
        }

        birthDate = DateTime.Parse(birthdate);

        Console.WriteLine("Enter Address One");
        addressOne = Console.ReadLine();

        Console.WriteLine("Enter Address Two");
        addressTwo = Console.ReadLine();

        Console.WriteLine("Enter City");
        city = Console.ReadLine();

        Console.WriteLine("Enter State");
        state = Console.ReadLine();

        Console.WriteLine("Enter Zip Code");
        zipCode = Console.ReadLine();

        Console.WriteLine("Enter Country");
        country = Console.ReadLine();

        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", firstName, lastName, birthDate, addressOne, addressTwo, city, state,
        zipCode, country);
    }
}