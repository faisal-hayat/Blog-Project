using Microsoft.EntityFrameworkCore;

namespace BlogProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }

}
