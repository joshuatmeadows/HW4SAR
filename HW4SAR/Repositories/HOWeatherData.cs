using HW4SAR.Data;
using HW4SAR.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HW4SAR.Repositories
{
    public class HOWeatherData : IHOWeatherData
    {
        private readonly DBContextClass _dBContextClass;
        public HOWeatherData(DBContextClass dBContextClass)
        {
            _dBContextClass = dBContextClass;
        }
        public async Task<List<WeatherForecast>> GetWeatherForecastsInAugust (int CID)
        {
            var param = new SqlParameter("@CID", CID);
            var WeatherForecastDeets = await Task.Run(() => _dBContextClass.WeatherForecasts.FromSqlRaw("exec spGetWeatherForecastsInAugust @CID", param).ToListAsync());
            return WeatherForecastDeets;
            }
    }
}
