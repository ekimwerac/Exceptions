// See https://aka.ms/new-console-template for more information
//In this example:
// 1. We define a custom exception class MyException, which inherits from Exception and includes a boolean property MinorFault.
// 2. We use an exception initializer when throwing a MyException, setting the MinorFault property to true.
// 3. In the catch block, we use the when clause to filter exceptions. The first catch block catches MyException instances where MinorFault is true, and the second catch block catches instances where MinorFault is false. The messages displayed in each catch block depend on the value of the MinorFault property.
// 4. If no exception matches the conditions in the first two catch blocks, the third catch block catches any other exceptions and displays a general message.
// 5. This allows you to use the MinorFault property to distinguish and handle exceptions differently based on their custom properties.
using System;

public class MyException : Exception
{
    public bool MinorFault { get; set; }

    public MyException() : base("Custom Exception")
    {
        MinorFault = false;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Simulate throwing a MyException with MinorFault set to true
            throw new MyException() { MinorFault = true };
        }
        catch (MyException ex) when (ex.MinorFault)
        {
            Console.WriteLine("Caught a MyException with MinorFault set to true");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (MyException ex) when (!ex.MinorFault)
        {
            Console.WriteLine("Caught a MyException with MinorFault set to false");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught a general exception");
            Console.WriteLine($"Exception Message: {ex.Message}");
        }
    }
}
