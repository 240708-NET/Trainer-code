public class Engine : IEngine{

    public string EngineType { get; set; }
    public int HorsePower { get; set; }
    public int Cylinders { get; set; }

    public Engine(string engineType, int horsePower, int cylinders)
    {
        this.EngineType = engineType;
        this.HorsePower = horsePower;
        this.Cylinders = cylinders;
    }

    public void StartEngine(){
        Console.WriteLine ($"The {EngineType} starts");
    }


}