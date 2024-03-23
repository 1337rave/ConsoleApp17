using System;

// Delegate declaration for arithmetic checks
public delegate bool ArithmeticCheck(int num);

// ArithmeticChecker class
public class ArithmeticChecker
{
    // Method to check if a number is even
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    // Method to check if a number is odd
    public static bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    // Method to check if a number is prime
    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    // Method to check if a number is in the Fibonacci sequence
    public static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;
        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == num;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Predicate delegate instances for different checks
        Predicate<int> isEvenPredicate = ArithmeticChecker.IsEven;
        Predicate<int> isOddPredicate = ArithmeticChecker.IsOdd;
        Predicate<int> isPrimePredicate = ArithmeticChecker.IsPrime;
        Predicate<int> isFibonacciPredicate = ArithmeticChecker.IsFibonacci;

        // Test arithmetic checks using delegates with Invoke method
        int num = 8;

        Console.WriteLine($"{num} is even: {isEvenPredicate.Invoke(num)}");
        Console.WriteLine($"{num} is odd: {isOddPredicate.Invoke(num)}");
        Console.WriteLine($"{num} is prime: {isPrimePredicate.Invoke(num)}");
        Console.WriteLine($"{num} is in Fibonacci sequence: {isFibonacciPredicate.Invoke(num)}");
    }
}
