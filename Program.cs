using System;

class Program
{
    static void Main()
    {
        // Greet the user with the required message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the weight of the package
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine()); // Convert user input to a number

        // Check if weight exceeds the allowed limit
        if (weight > 50)
        {
            // Display error message and exit if package is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt for package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt for package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt for package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate the sum of dimensions to check if it exceeds the limit
        double dimensionTotal = width + height + length;

        // Check if dimensions are too large
        if (dimensionTotal > 50)
        {
            // Display error message and exit if package is too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the quote:
        // Volume (width * height * length) multiplied by weight, divided by 100
        double quote = (width * height * length * weight) / 100;

        // Display the result, formatted as a currency amount with two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user
        Console.WriteLine("Thank you!");
    }
}
