

using Microsoft.EntityFrameworkCore;
using YandexTaxi.Domain.Entities;

namespace YandexTaxi.Application.Absreactions
{
    public interface IYandexTaxiDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
