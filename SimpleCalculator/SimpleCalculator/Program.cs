using System;

class SimpleCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0]; 

        int result = 0;

        if (operation == '+')
            result = num1 + num2;
        else if (operation == '-')
            result = num1 - num2;
        else if (operation == '*')
            result = num1 * num2;
        else if (operation == '/')
        {
            if (num2 != 0)
                result = num1 / num2; 
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operation.");
            return;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}
