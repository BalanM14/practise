using Microsoft.EntityFrameworkCore;

namespace BefTry.Model
{
    public class SocilaMediaContext : DbContext
    {
        public SocilaMediaContext(DbContextOptions<SocilaMediaContext> options) : base(options) 
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
