using System;

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsGroupOne = { "Zdravko", "Petko", "Stanko", "Brank", "Trajko"};
            string[] studentsGroupTwo = { "Zoki", "Mile", "Brus", "Petko", "Vele"};
            Console.WriteLine("Enter student group (1 or 2)!");
            bool number = int.TryParse(Console.ReadLine(), out int num);
            if (number)
            {
                if(num == 1)
                {
                    Console.WriteLine("Students in group 1:");
                    foreach(string student in studentsGroupOne)
                    {
                        Console.WriteLine(student);
                    }
                }
                if (num == 2)
                {
                    Console.WriteLine("Students in group 2:");
                    foreach (string student in studentsGroupTwo)
                    {
                        Console.WriteLine(student);
                    }
                }
                else Console.WriteLine("Invalid group number. There are only 2 groups!");
            }
            else Console.WriteLine("Invalid parameter!");
        }
    }
}
