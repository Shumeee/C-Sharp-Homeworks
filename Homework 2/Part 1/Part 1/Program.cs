using System;

namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int sum = 0;
            Console.WriteLine("Enter 6 elements in array:");
            for (int i = 0; i < array.Length; i++)
            {
                bool element = int.TryParse(Console.ReadLine(), out int num);
                if (element)
                {
                    array[i] = num;
                }
                else
                {
                    Console.WriteLine("Please enter a valid element!");
                    i--;
                }
            }
            foreach (int element in array)
            {
                if(element % 2 == 0)
                {
                    sum += element;
                }
            }  
            Console.WriteLine($"The sum of all even elements in the array is {sum}");
        }
    }
}
