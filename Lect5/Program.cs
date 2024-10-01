
using Lect5.Data;
using Microsoft.EntityFrameworkCore;

namespace Lect5
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

			// configure the connectionstring from the configuration file appsettings.json			
			builder.Services.AddDbContext<BookStoreContext>(
					options => options.UseSqlServer(
						builder.Configuration.GetConnectionString("TarekDesktopConnection")
						)
				);

			// Add Swagger to the project for API documentation and testing purposes.			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

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
