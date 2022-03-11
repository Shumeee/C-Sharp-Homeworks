using System;

namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            bool parsednum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter operand: ");
            string operand = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            bool parsednum2 = int.TryParse(Console.ReadLine(), out int num2);
            if (parsednum1 && parsednum2)
            {
                switch (operand)
                {
                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine($"Error! Invalid operator '{operand}' ");
                        break;
                }
            }else Console.WriteLine("Invalid parameters!");
        }
    }
}
