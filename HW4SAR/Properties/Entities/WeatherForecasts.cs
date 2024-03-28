using System.ComponentModel.DataAnnotations;

namespace HW4SAR.Entities
{
    public class WeatherForecasts
    {

            public int CID { get; set; }
            public int WFTemp { get; set; }
            public DateTime WFDate { get; set; }
    }
}
