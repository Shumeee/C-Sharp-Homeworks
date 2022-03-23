using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Car[] Cars = {
                new Car("McLaren P1", 350, new Driver("Michael Schumacher", 100)),
                new Car("Lamborghini Aventador SVJ", 219, new Driver("Fernando Alonso", 98)),
                new Car("Bugatti Chiron", 420, new Driver("Ayrton Senna", 99)),
                new Car("Porshe 918 Spyder", 344, new Driver("Max Verstappen", 100))
            };
            while (flag)
            {
                Console.WriteLine("Welcome to the Grand Prix 2022!");
                // Choose 1st vehicle
                Console.WriteLine("Choose your first vehicle: ");
                PrintCars(Cars, "");
                bool parseCarOne = int.TryParse(Console.ReadLine(), out int inputCarOne);
                if (!CheckInput(parseCarOne, inputCarOne)) return;
                string carOne = Cars[inputCarOne - 1].Model;
                // Choose 1st driver
                Console.WriteLine("Choose your driver: ");
                PrintDrivers(Cars, "");
                bool parseDriverOne = int.TryParse(Console.ReadLine(), out int inputDriverOne);
                if (!CheckInput(parseDriverOne, inputDriverOne)) return;
                string driverOne = Cars[inputDriverOne - 1].Driver.Name;
                // Choose 2nd vehicle
                Console.WriteLine("Choose your second vehicle: ");
                PrintCars(Cars, carOne);
                bool parseCarTwo = int.TryParse(Console.ReadLine(), out int inputCarTwo);
                if (!CheckInput(parseCarTwo, inputCarTwo)) return;
                if (!CheckIdenticalInputCar(inputCarOne, inputCarTwo)) return;
                // Choose 2nd driver
                Console.WriteLine("Choose your driver: ");
                PrintDrivers(Cars, driverOne);
                bool parseDriverTwo = int.TryParse(Console.ReadLine(), out int inputDriverTwo);
                if (!CheckInput(parseDriverTwo, inputDriverTwo)) return;
                if (!CheckIdenticalInputDriver(inputDriverOne, inputDriverTwo)) return;
                // The cars race
                RaceCars(Cars, inputCarOne, inputDriverOne, inputCarTwo, inputDriverTwo);
                // Race again
                Console.WriteLine("\nDo you want to race again? Y / N");
                string raceAgain = Console.ReadLine();
                switch (raceAgain.ToLower())
                {
                    case "y":
                        flag = true;
                        break;
                    case "n":
                        Console.WriteLine("Thank you for racing!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        return;
                }
            }
        }
        // Race
        static void RaceCars(Car[] car, int carOne, int driverOne, int carTwo, int driverTwo)
        {
            if (car[carOne - 1].CalculateSpeed(car[carOne - 1].Speed, car[driverOne - 1].Driver.Skill) > car[carTwo - 1].CalculateSpeed(car[carTwo - 1].Speed, car[driverTwo - 1].Driver.Skill))
            {
                Console.WriteLine($"WINNER: \nModel: {car[carOne - 1].Model} \nSpeed: {car[carOne - 1].Speed}km\\h \nDriver: {car[driverOne - 1].Driver.Name}");
            }
            else Console.WriteLine($"WINNER: \nModel: {car[carTwo - 1].Model} \nSpeed: {car[carTwo - 1].Speed}km\\h \nDriver: {car[driverTwo - 1].Driver.Name}");
        }
        // Prints cars
        static void PrintCars(Car[] cars, string inputCar)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (inputCar != cars[i].Model) Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
        }
        // Prints drivers
        static void PrintDrivers(Car[] driver, string inputDriver)
        {
            for (int i = 0; i < driver.Length; i++)
            {
                if(inputDriver != driver[i].Driver.Name) Console.WriteLine($"{i + 1}. {driver[i].Driver.Name}");
            }
        }
        // Checks if the input for car/driver is valid
        static bool CheckInput(bool parse, int input)
        {
            if (!parse || input > 4)
            {
                Console.WriteLine("Invalid input!");
                return false;
            }
            else return true;
        } 
        // Checks if the input is the same for the driver
        static bool CheckIdenticalInputDriver(int firstInput, int secondInput)
        {
            if (secondInput == firstInput)
            {
                Console.WriteLine("Cannot pick the same driver!");
                return false;
            }
            else return true;
        }
        // Checks if the input is the same for the car
        static bool CheckIdenticalInputCar(int firstInput, int secondInput)
        {
            if (secondInput == firstInput)
            {
                Console.WriteLine("Cannot pick the same car!");
                return false;
            }
            else return true;
        }
    }
}
