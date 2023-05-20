using BlogSite.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Data
{
    public class BlogSiteDBContext: DbContext
    {
        public BlogSiteDBContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
