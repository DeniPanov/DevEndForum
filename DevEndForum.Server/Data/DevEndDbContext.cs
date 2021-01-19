namespace DevEndForum.Server.Data
{
    using DevEndForum.Server.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class DevEndDbContext : IdentityDbContext<User>
    {
        public DevEndDbContext(DbContextOptions<DevEndDbContext> options)
            : base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Opinion> Opinions { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public override DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
