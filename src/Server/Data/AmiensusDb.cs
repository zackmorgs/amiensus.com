using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class AmiensusDb(DbContextOptions<AmiensusDb> options) : IdentityDbContext<ApplicationUser>(options)
    {
    }
}
