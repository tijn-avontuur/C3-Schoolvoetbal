using C3_Schoolvoetbal_Backend.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C3_Schoolvoetbal_Backend;

public class SchoolVoetbalDbContext(DbContextOptions<SchoolVoetbalDbContext> options) : IdentityDbContext<IdentityUser>(options) {
    public DbSet<Team> Teams { get; set; }
}
