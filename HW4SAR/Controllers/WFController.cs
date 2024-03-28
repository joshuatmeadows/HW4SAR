using HW4SAR.Entities;
using HW4SAR.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HW4SAR.Controllers
{
    [Route("api/[contoller]")]
    [ApiController]
    public class WFController : Controller
    {
        private readonly IHOWeatherData _HOWeatherData;
        public WFController(IHOWeatherData hOWeatherData)
        {
            _HOWeatherData = hOWeatherData;
        }
        [HttpGet("{CID}")]
        public async Task<ActionResult<List<WeatherForecast>>> GetWeatherForecastsInAugust(int CID) 
        {
            var weatherForecastDeets = await _HOWeatherData.GetWeatherForecastsInAugust(CID); 
            if (weatherForecastDeets == null)
            {
                return NotFound(); 
            }
            return Ok(weatherForecastDeets); 
        }
    }
}

