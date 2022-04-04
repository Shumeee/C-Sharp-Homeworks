using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> numbers = new Queue<double>();
            bool flag = true;
            double number = 0;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                     number = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    flag = false;
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    numbers.Enqueue(number);
                    Console.WriteLine("Would you like to add another number? Y / N");
                    string input = Console.ReadLine();
                    if (!CheckInput(input.ToLower()) && flag) flag = false;
                }
            }
            PrintNumbers(numbers);
        }
        static void PrintNumbers(Queue<double> numbers)
        {
            Console.WriteLine("The numbers you entered are: ");
            foreach(double number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
        static bool CheckInput(string input)
        {
            if(input == "y")
            {
                return true;
            }
            else if(input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please select Y or N !");
                return false;
            }
            return true;
        }
    }
}
