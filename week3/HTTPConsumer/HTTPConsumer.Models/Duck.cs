namespace HTTPConsumer.Models
{
    public class Duck
    {
        public int? id { get; set; }
        public string color { get; set; }
        public int numFeathers { get; set; }
    }

    public class DuckDTO
    {
        public string color { get; set; }
        public int numFeathers { get; set; }
    }
}