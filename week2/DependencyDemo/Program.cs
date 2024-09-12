using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Configure DI container
        var serviceProvider = new ServiceCollection()
            .AddTransient<IEngine, Engine>() // Register Engine implementation
            .AddTransient<Car>() // Register Car class
            .BuildServiceProvider();

        // Resolve Car instance from DI container
        var car = serviceProvider.GetService<Car>();
        car.printingEngineDetails();
    }
}
