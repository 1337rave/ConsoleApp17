using System;

// Delegate declaration for arithmetic operations
public delegate double ArithmeticOperation(double x, double y);

// Calculator class
public class Calculator
{
    // Method to perform addition
    public static double Add(double x, double y)
    {
        return x + y;
    }

    // Method to perform subtraction
    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    // Method to perform multiplication
    public static double Multiply(double x, double y)
    {
        return x * y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create delegate instances for different operations
        ArithmeticOperation addDelegate = Calculator.Add;
        ArithmeticOperation subtractDelegate = Calculator.Subtract;
        ArithmeticOperation multiplyDelegate = Calculator.Multiply;

        // Test arithmetic operations using delegates
        double num1 = 10;
        double num2 = 5;

        Console.WriteLine($"Addition: {num1} + {num2} = {addDelegate(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {subtractDelegate(num1, num2)}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplyDelegate(num1, num2)}");
    }
}
