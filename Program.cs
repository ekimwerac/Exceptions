// See https://aka.ms/new-console-template for more information
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

    public CustomException(string message, Exception innerException, DateTime timestamp, string additionalInfo)
        : base(message, innerException)
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

