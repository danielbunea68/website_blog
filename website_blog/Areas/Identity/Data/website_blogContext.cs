using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website_blog.Areas.Identity.Data;

namespace website_blog.Data;

public class website_blogContext : IdentityDbContext<blogUser>
{
	protected readonly IConfiguration Configuration;
	public website_blogContext(DbContextOptions<website_blogContext> options, IConfiguration configuration)
        : base(options)
    {
		Configuration = configuration;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection"));

	}
	
	protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
