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
    }
}
