using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{
    // 2. Fixed spelling: Changed 'DBContext' to 'DbContext' to match Program.cs
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        // 3. Entity Framework best practice: Pluralized 'Comment' to 'Comments'
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Comments> Comments { get; set; } 
    }
}
