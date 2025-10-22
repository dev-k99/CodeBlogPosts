using CodePulse.AI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.AI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

     public DbSet<BlogPost> BlogPosts { get; set; }
     public DbSet<Category> Categories { get; set; }
    }
}
