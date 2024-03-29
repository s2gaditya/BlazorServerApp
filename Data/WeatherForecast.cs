namespace BlazorServerApp.Data
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        
        public DateTime UpdateDate { get; set; }

        public string? Area { get; set; }

        public string? PinCode { get; set; }

        public string? Test11 { get; set; }
    }
}
