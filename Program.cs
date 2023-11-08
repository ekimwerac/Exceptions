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
            // Simulate an inner exception
            var innerException = new InvalidOperationException("Inner exception occurred");
            throw new CustomException("Custom exception occurred", innerException, DateTime.Now, "Some additional information");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom Exception Details:");
            Console.WriteLine($"Message: {ex.Message}");
            Console.WriteLine($"Timestamp: {ex.Timestamp}");
            Console.WriteLine($"Additional Info: {ex.AdditionalInfo}");

            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner Exception Details:");
                Console.WriteLine($"Message: {ex.InnerException.Message}");
                // You can access additional properties of the inner exception here.
            }
        }
    }
}

