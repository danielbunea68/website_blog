using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website_blog.Areas.Identity.Data;

namespace website_blog.Data
{
    public class AppDbContext: IdentityDbContext<blogUser>
	{
        
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// Customize the ASP.NET Identity model and override the defaults if needed.
			// For example, you can rename the ASP.NET Identity table names and more.
			// Add your customizations after calling base.OnModelCreating(builder);
		}
		public DbSet<Post> Posts { get; set; }
        public DbSet<Comment>Comments{ get; set; }

    }
}
