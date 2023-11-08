// See https://aka.ms/new-console-template for more information
// In C#, you can create a custom exception by defining a new class that inherits
// from the Exception class or one of its derived classes, such as System.Exception.
// To provide rich details in your custom exception, you can add additional properties
// or fields to the class and override the base exception constructors.

// In the example below, we've created a custom exception class named CustomException.
// It has two additional properties, Timestamp and AdditionalInfo, which enrich the exception with custom details.
// We've defined one constructors to initialize these properties.
// The Main method demonstrates how to throw and catch the custom exception, allowing you to access its details.

// You can further extend and customize your custom exception class to include any relevant information you need to convey when exceptions are raised in your application.

// Here's the example:

using System;

public class CustomException : Exception
{
    public DateTime Timestamp { get; }
    public string AdditionalInfo { get; }

    public CustomException(string message, DateTime timestamp, string additionalInfo)
        : base(message)
    {
        Timestamp = timestamp;
        AdditionalInfo = additionalInfo;
    }
    // You can add more constructors and properties as needed.
}

class Program
{
    static void Main()
    {
        try
        {
            throw new CustomException("Custom exception occurred", DateTime.Now, "Some additional information");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom Exception Details:");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Timestamp: {ex.Timestamp}");
            Console.WriteLine($"Additional Info: {ex.AdditionalInfo}");
        }
    }
}

