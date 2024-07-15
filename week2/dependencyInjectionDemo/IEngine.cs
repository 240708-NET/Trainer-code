public interface IEngine{

    public string EngineType { get; set; }
    public int HorsePower { get; set; }
    public int Cylinders { get; set; }

    public void StartEngine();
}