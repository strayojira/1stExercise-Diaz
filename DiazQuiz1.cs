using System;

public class DiazQuiz1
{
    public static void Main(string[] args)
    {

        // number 1

        Console.WriteLine("input 1");
        string input1 = Console.ReadLine();
        Console.WriteLine("input 2");
        string input2 = Console.ReadLine();
        Console.WriteLine("input 3");
        string input3 = Console.ReadLine();
        Console.WriteLine("input 4");
        string input4 = Console.ReadLine();
        Console.WriteLine("input 5");
        string input5 = Console.ReadLine();

        Console.WriteLine("=========================");

        Console.WriteLine("You entered: ");
        Console.WriteLine("");
        Console.WriteLine(input1);
        Console.WriteLine(input2);
        Console.WriteLine(input3);
        Console.WriteLine(input4);
        Console.WriteLine(input5);

        Console.WriteLine("=========================");

        // number 2 -- 6. loan calculator

        Console.WriteLine("Enter your loan amount:");
        int loan = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your annual interest rate:");
        double annualRate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of years:");
        int years = int.Parse(Console.ReadLine());

        double interest = loan * annualRate * years;

        double totalPayment = loan + interest;

        double monthlyPayment = totalPayment / (years * 12);

        Console.WriteLine("");

        bool isLoanBig = loan >= 100000;

        bool isInterestBig = interest > 20000;

        bool isMonthlyPaymentBig = monthlyPayment >= 5000;

        Console.WriteLine($"Your loan is: PHP {loan:F2}");

        Console.WriteLine($"Your interest is: PHP {interest:F2}");

        Console.WriteLine($"Your monthly payment is: PHP {monthlyPayment:F2}");

        Console.WriteLine("");

        Console.WriteLine($"Is the loan >= PHP100,000? {isLoanBig}");

        Console.WriteLine($"Is the interest > PHP20,000? {isInterestBig}");

        Console.WriteLine($"Is the monthly payment >= PHP5,000? {isMonthlyPaymentBig}");
    }
}



