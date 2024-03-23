using System;

// Delegate declaration
public delegate void DisplayMessageDelegate(string message);

// Application class
public class MessageApp
{
    // Method to display message
    public static void DisplayMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    // Method to display message in uppercase
    public static void DisplayMessageUppercase(string message)
    {
        Console.WriteLine("Message: " + message.ToUpper());
    }

    // Method to display message in lowercase
    public static void DisplayMessageLowercase(string message)
    {
        Console.WriteLine("Message: " + message.ToLower());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating delegate instance
        DisplayMessageDelegate showMessageDelegate = MessageApp.DisplayMessage;

        // Test by invoking the delegate with different methods
        showMessageDelegate("Hello, World!");
        showMessageDelegate = MessageApp.DisplayMessageUppercase;
        showMessageDelegate("Hello, World!");
        showMessageDelegate = MessageApp.DisplayMessageLowercase;
        showMessageDelegate("Hello, World!");
    }
}
