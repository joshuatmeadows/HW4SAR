using System.ComponentModel.DataAnnotations;

namespace HW4SAR
{
    public class WeatherForecast
    {
        [Key]
        public int CID { get; set; }
        public DateOnly WFDate { get; set; }

        public int WFTemp { get; set; }

        public int TemperatureF => 32 + (int)(WFTemp / 0.5556);

        //public string? Summary { get; set; }
    }
}
