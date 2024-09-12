public class Engine : IEngine{

    public string EngineType { get; set; }
    public int HorsePower { get; set; }
    public int Cylinders { get; set; }

    public Engine()
    {
        this.EngineType = "V8";
        this.HorsePower = 560;
        this.Cylinders = 8;
    }

    public void StartEngine(){
        Console.WriteLine ($"The {EngineType} starts");
    }


}