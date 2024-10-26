using System;

namespace MethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the PerformOperation method, passing in two numbers
            mathOperations.PerformOperation(5, 10);

            // Call the PerformOperation method again, specifying the parameters by name
            mathOperations.PerformOperation(num1: 8, num2: 15);

            // Keep the console window open to see the results
            Console.ReadLine();
        }
    }
}
