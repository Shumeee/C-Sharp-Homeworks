using System;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            bool parsednum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter second number: ");
            bool parsednum2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter third number: ");
            bool parsednum3 = int.TryParse(Console.ReadLine(), out int num3);
            Console.WriteLine("Enter fourth number: ");
            bool parsednum4 = int.TryParse(Console.ReadLine(), out int num4);
            int sum = num1 + num2 + num3 + num4;
            if ((parsednum1 && parsednum2 && parsednum3 && parsednum4) && sum != 0)
            {
                Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is {sum / 4}");
            }else if (sum == 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
            }else Console.WriteLine("Invalid parameters!");
        }
    }
}
