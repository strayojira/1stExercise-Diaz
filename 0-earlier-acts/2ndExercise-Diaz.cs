using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // ── Exercise 1: Student Information 
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Course: ");
        string course = Console.ReadLine();
        Console.WriteLine("Year Level: ");
        string year = Console.ReadLine();
        Console.WriteLine("Section: ");
        string section = Console.ReadLine();

        Console.WriteLine("=======================");
        Console.WriteLine("Your Name: " + name);
        Console.WriteLine("Your Course: " + course);
        Console.WriteLine("Your Year Level: " + year);
        Console.WriteLine("Your Section: " + section);
        Console.WriteLine("=======================\n");

        // ── Exercise 2: Basic Calculator
        Console.WriteLine("=== Exercise 2: Basic Calculator ===");
        Console.WriteLine("Enter Number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Another Number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Addition: "       + (num1 + num2));
        Console.WriteLine("Subtraction: "    + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: "       + (num1 / num2));
        Console.WriteLine("=======================\n");

        // ── Exercise 3: Area of a Rectangle
        Console.WriteLine("=== Exercise 3: Area of a Rectangle ===");
        Console.WriteLine("Enter Length: ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Area: " + (length * width));
        Console.WriteLine("=======================\n");

        // ── Exercise 4: Student Grade
        Console.WriteLine("=== Exercise 4: Student Grade ===");
        Console.WriteLine("Enter Prelim Grade: ");
        double prelim = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Midterm Grade: ");
        double midterm = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Final Grade: ");
        double final = double.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Average: " + ((prelim + midterm + final) / 3));
        Console.WriteLine("=======================\n");

        // ── Exercise 5: Boolean Input
        Console.WriteLine("=== Exercise 5: Boolean Input ===");
        Console.WriteLine("Are you a student? (true/false): ");
        bool isStudent = bool.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Is Student: " + isStudent);
        Console.WriteLine("=======================\n");

        // ── Exercise 6: Age Verification
        Console.WriteLine("=== Exercise 6: Age Verification ===");
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        bool isAdult = age >= 18;

        Console.WriteLine("=======================");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Is Adult (18+): " + isAdult);
        Console.WriteLine("=======================\n");

        // ── Exercise 7: Full Name
        Console.WriteLine("=== Exercise 7: Full Name ===");
        Console.WriteLine("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("=======================");
        Console.WriteLine("Full Name: " + firstName + " " + lastName);
        Console.WriteLine("=======================\n");

        // ── Exercise 8: Shopping Calculator
        Console.WriteLine("=== Exercise 8: Shopping Calculator ===");
        Console.WriteLine("Enter Product Name: ");
        string product = Console.ReadLine();
        Console.WriteLine("Enter Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Total: " + (price * quantity));
        Console.WriteLine("=======================\n");

        // ── Exercise 9: Salary Calculator 
        Console.WriteLine("=== Exercise 9: Salary Calculator ===");
        Console.WriteLine("Enter Employee Name: ");
        string empName = Console.ReadLine();
        Console.WriteLine("Enter Hours Worked: ");
        double hours = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Hourly Rate: ");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("=======================");
        Console.WriteLine("Employee: " + empName);
        Console.WriteLine("Salary: " + (hours * rate));
        Console.WriteLine("=======================\n");

        // ── Exercise 10: Mini Student Information System
        Console.WriteLine("=== Exercise 10: Mini Student Information System ===");
        Console.WriteLine("Enter Name: ");
        string sisName = Console.ReadLine();
        Console.WriteLine("Enter Course: ");
        string sisCourse = Console.ReadLine();
        Console.WriteLine("Enter Age: ");
        int sisAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Year Level: ");
        string sisYear = Console.ReadLine();
        Console.WriteLine("Enter Prelim Grade: ");
        double sisPrelim = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Midterm Grade: ");
        double sisMidterm = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Final Grade: ");
        double sisFinal = double.Parse(Console.ReadLine());

        double sisAverage = (sisPrelim + sisMidterm + sisFinal) / 3;
        bool sisIsAdult = sisAge >= 18;

        Console.WriteLine("=======================");
        Console.WriteLine("Name: "          + sisName);
        Console.WriteLine("Course: "        + sisCourse);
        Console.WriteLine("Age: "           + sisAge);
        Console.WriteLine("Year Level: "    + sisYear);
        Console.WriteLine("Prelim: "        + sisPrelim);
        Console.WriteLine("Midterm: "       + sisMidterm);
        Console.WriteLine("Final: "         + sisFinal);
        Console.WriteLine("Average Grade: " + sisAverage);
        Console.WriteLine("Is Adult (18+): "+ sisIsAdult);
        Console.WriteLine("=======================");
    }
}
