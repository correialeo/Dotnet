using Microsoft.EntityFrameworkCore;
using Models.Blog;
using Models.Post;

namespace Data.BloggingContext{

    public class BloggingContext : DbContext{
        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlite("Data Source=blogging.db");
            }
        }
    }
    
}
