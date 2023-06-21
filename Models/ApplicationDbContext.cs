using BlogProject.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        // This is where we will be adding the tables to the database
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }

}
