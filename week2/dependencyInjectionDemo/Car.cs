public class Car {

    private readonly IEngine _engine;

    public Car(IEngine engine)
    {
        _engine = engine;
    }

    public void printingEngineDetails(){
        Console.WriteLine($"Engine Type: {_engine.EngineType}");
        Console.WriteLine($"Engine Horsepower: {_engine.HorsePower} hp");
    }


}