using DevAssistant.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevAssistant
{
    public static class Dependency_Injection
    {
        public static IServiceCollection SwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen();
            return services;
        }

        public static IServiceCollection Database(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(s => s.UseSqlServer(connectionstring));
            return services;
        }
        
    }
}
