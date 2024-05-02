//using MediatR;
//using MySqlConnector;
//using TrackingApi;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);
////builder.Services.AddTransient(x=> new MySqlConnection(builder.Configuration.GetConnectionString("Dafault")));
//builder.Services.AddMediatR(typeof(Startup));

//var app = builder.Build();
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
using MySqlConnector;
using TrackingApi.infrastructure;

namespace Sellersvc.Service
{
    public class Program
    {

        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();
            var builder =WebApplication.CreateBuilder(args);
            // builder.Run();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.RegisterBusinessService(builder.Configuration);
            //builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default")!);
            //builder.Services.AddTransient(x=> new MySqlConnection(builder.Configuration.GetConnectionString("Dafault")));

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
        

    }
   
}
