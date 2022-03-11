using System;

namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for A: ");
            bool parsednum1 = double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Enter the value for B: ");
            bool parsednum2 = double.TryParse(Console.ReadLine(), out double num2);
            double pom;
            if (parsednum1 && parsednum2)
            {
                Console.WriteLine($"Numbers before swap: a = {num1} b = {num2}");
                pom = num1;
                num1 = num2;
                num2 = pom;
                Console.WriteLine($"Numbers after swap: a = {num1} b = {num2}");
            }else Console.WriteLine("Invalid parameters!");
        }
    }
}
