using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Absreactions;
using YandexTaxi.Domain.Entities;

namespace YandexTaxi.Infastructure.Persistance
{
    public class YandexTaxiDbContext : DbContext,IYandexTaxiDbContext
    {
        public YandexTaxiDbContext(DbContextOptions<YandexTaxiDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
