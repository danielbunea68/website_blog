using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace website_blog.Data

{
	public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
	{
		public AppDbContext CreateDbContext(string[] arg) {
			IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

			var builder = new DbContextOptionsBuilder<AppDbContext>();
			var connectionString = configuration.GetConnectionString("DatabaseConnection");
			builder.UseSqlServer(connectionString);
			return  new AppDbContext(builder.Options);


		}
	}
}
