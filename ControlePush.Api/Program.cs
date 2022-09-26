using ControlePush.Application;
using ControlePush.Repository;
using Microsoft.EntityFrameworkCore;

namespace ControlePush.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //builder.Services.AddControllers();
            
            builder.Services.AddControllers().AddNewtonsoftJson();

            builder.Services
                   .RegisterApplication()
                   .RegisterRepository(builder.Configuration.GetConnectionString("ControlePushConnection"));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}