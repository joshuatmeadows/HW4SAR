using HW4SAR.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW4SAR.Data
{
    public class DBContextClass: DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options): base(options)
        { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; } 
    }
}
