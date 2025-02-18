using TechnicalAirTechTest.Services;
using TechnicalAirTechTest.Utilities;

class Program
{
    static void Main()
    {
        // Problem 1
        Console.WriteLine("\nProblem 1:");
        GreeterService greeter = new GreeterService("Maik");
        greeter.Hello();

        // Problem 2
        Console.WriteLine("\nProblem 2:");
        foreach (var city in CityAnalizer.GetTopCities(5))
        {
            Console.WriteLine($"{city.Key}: {city.Value}");
        }
    }
}