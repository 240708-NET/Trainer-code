namespace HTTPConsumer.Models
{
    public class Forecast
    {
        public string date { get; set; }
        public int temperatureC { get; set; }
        public int temperatureF { get; set; }
        public string summary { get; set; }
    }
}