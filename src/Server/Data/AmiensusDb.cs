using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class AmiensusDb(DbContextOptions<AmiensusDb> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
