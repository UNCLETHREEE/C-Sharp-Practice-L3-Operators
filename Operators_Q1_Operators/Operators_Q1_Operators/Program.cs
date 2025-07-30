using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //---------------------------------------------------------------------
        // Question 1: Sum of Two Numbers
        // Write a C# program to print the sum of two numbers.
        // Hint: You can use the + operator to add two numbers.
        // Test data: int num1 = 10, int num2 = 5
        /* Simple arithmetic using the + operator. */
        int num1 = 10, num2 = 5;
        Console.WriteLine("Sum: " + (num1 + num2));

        //---------------------------------------------------------------------
        // Question 2: Difference Between Two Numbers
        // Write a C# program to print the difference between two numbers.
        /* Use the - operator. */
        Console.WriteLine("Difference: " + (num1 - num2));

        //---------------------------------------------------------------------
        // Question 3: Product of Two Numbers
        // Write a C# program to print the product of two numbers.
        /* Use the * operator. */
        Console.WriteLine("Product: " + (num1 * num2));

        //---------------------------------------------------------------------
        // Question 4: Division of Two Numbers
        // Write a C# program to print the division of two numbers.
        /* Use the / operator. */
        Console.WriteLine("Division: " + (num1 / num2));

        //---------------------------------------------------------------------
        // Question 5: Remainder of Two Numbers
        // Write a C# program to print the remainder of two numbers.
        /* Use the % operator. */
        Console.WriteLine("Remainder: " + (num1 % num2));

        //---------------------------------------------------------------------
        // Question 6: Square of a Number
        // Write a C# program to calculate the square of a number.
        /* Multiply the number by itself. */
        int num = 5;
        Console.WriteLine("Square: " + (num * num));

        //---------------------------------------------------------------------
        // Question 7: Average of Two Numbers
        // Write a C# program to calculate the average of two numbers.
        /* Add and divide by 2. */
        int avg2 = (num1 + num2) / 2;
        Console.WriteLine("Average (2 numbers): " + avg2);

        //---------------------------------------------------------------------
        // Question 8: Average of Three Numbers
        // Write a C# program to calculate the average of three numbers.
        /* Add three numbers and divide by 3. */
        int num3 = 30;
        int avg3 = (num1 + num2 + num3) / 3;
        Console.WriteLine("Average (3 numbers): " + avg3);

        //---------------------------------------------------------------------
        // Question 9: Celsius to Fahrenheit
        // Convert Celsius to Fahrenheit using the formula.
        double celsius = 20;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit: " + fahrenheit);

        //---------------------------------------------------------------------
        // Question 10: Area of Rectangle
        // Calculate area using area = length * width.
        double length = 10, width = 5;
        double area = length * width;
        Console.WriteLine("Area of rectangle: " + area);

        //---------------------------------------------------------------------
        // Question 11: Volume of Sphere
        // Use formula (4/3) * π * r³.
        double radius = 5;
        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("Volume of sphere: " + volume);

        //---------------------------------------------------------------------
        // Question 12: Factorial of a Number
        // Loop from 1 to num and multiply.
        int factorial = 1;
        for (int i = 1; i <= num; i++) factorial *= i;
        Console.WriteLine("Factorial of 5: " + factorial);

        //---------------------------------------------------------------------
        // Question 13: Compound Interest
        // Use formula A = P(1 + r)^t
        double principal = 1000, rate = 0.05;
        int time = 5;
        double compound = principal * Math.Pow((1 + rate), time);
        Console.WriteLine("Compound Interest: " + compound);

        //---------------------------------------------------------------------
        // Question 14: Solve Quadratic Equation
        // Use quadratic formula: x = (-b ± √D)/2a
        double a = 1, b = 5, c = 6;
        double discriminant = b * b - 4 * a * c;
        if (discriminant >= 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots: {root1} and {root2}");
        }
        else
        {
            Console.WriteLine("No real roots.");
        }

        //---------------------------------------------------------------------
        // Question 15: Fibonacci Number (Recursive)
        // Calculate nth Fibonacci number using recursion.
        int n = 8;
        Console.WriteLine($"Fibonacci({n}): " + Fibonacci(n));

        //---------------------------------------------------------------------
        // Question 16: Arithmetic Sequence
        // nth term = first + (n - 1) * diff
        int firstTerm = 3, commonDiff = 2, termNumber = 5;
        int nthTerm = firstTerm + (termNumber - 1) * commonDiff;
        Console.WriteLine("Nth term: " + nthTerm);

        //---------------------------------------------------------------------
        // Question 17: Greater Than Check
        // Use > operator
        Console.WriteLine("10 > 5? " + (10 > 5));

        //---------------------------------------------------------------------
        // Question 18: Less Than or Equal to 100
        // Input and check with <=
        Console.Write("Enter a number: ");
        int input18 = int.Parse(Console.ReadLine());
        Console.WriteLine("Less than or equal to 100? " + (input18 <= 100));

        //---------------------------------------------------------------------
        // Question 19: Even AND Greater Than 10
        // Use % and &&
        Console.Write("Enter a number: ");
        int input19 = int.Parse(Console.ReadLine());
        bool isEvenAndGT10 = (input19 % 2 == 0) && (input19 > 10);
        Console.WriteLine("Even and > 10? " + isEvenAndGT10);

        //---------------------------------------------------------------------
        // Question 20: Divisible by 3 OR 5
        // Use % and ||
        Console.Write("Enter a number: ");
        int input20 = int.Parse(Console.ReadLine());
        bool divisible = (input20 % 3 == 0) || (input20 % 5 == 0);
        Console.WriteLine("Divisible by 3 or 5? " + divisible);

        //---------------------------------------------------------------------
        // Question 21: += Operator
        // Use shorthand assignment
        Console.Write("Enter a number: ");
        int input21 = int.Parse(Console.ReadLine());
        input21 += 5;
        Console.WriteLine("After += 5: " + input21);

        //---------------------------------------------------------------------
        // Question 22: %= Operator
        // Get remainder and assign
        int number = 27;
        number %= 7;
        Console.WriteLine("After %= 7: " + number);
    }
   
}
