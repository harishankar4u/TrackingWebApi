using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System.Data;
using System.Reflection;
using TrackingApi.Data.contract;
using TrackingApi.Data.Manager;

namespace TrackingApi.infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterBusinessService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEmployee,Employees>();
           // services.AddTransient(x => new MySqlConnection(configuration.GetConnectionString("Default")));
            // services.AddTransient(x => new MySqlConnection(builder.Configuration.GetConnectionString("Dafault")));
             services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddTransient<IDbConnection>(x => new MySqlConnection(configuration.GetConnectionString("Default")));
            services.AddAutoMapper(typeof(ServiceRegistration));
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            // services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
