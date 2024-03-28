using HW4SAR.Entities;

namespace HW4SAR.Repositories
{
    public interface IHOWeatherData
    {
        public Task<List<WeatherForecast>> GetWeatherForecastsInAugust(int CID);
    }
}
