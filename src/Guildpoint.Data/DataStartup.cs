using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Guildpoint.Data
{
    public static class DataStartup
    {
        public static void AddGuildpointData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString =  configuration.GetConnectionString("DefaultConnection") ?? "Guildpoint.db";
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));
        }
    }
}
