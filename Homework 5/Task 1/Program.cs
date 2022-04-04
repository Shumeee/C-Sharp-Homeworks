using System;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> numbers = new Queue<double>();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    double number = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Do you want to input another number? Y / N");
                }
            }
        }
    }
}
