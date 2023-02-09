using Microsoft.EntityFrameworkCore;

namespace rest2.Infrastructure;

public class MSSqlDbContext: DbContext, IDbContext
{
    public MSSqlDbContext(DbContextOptions<MSSqlDbContext> options) : base(options)
    {
    }
    
    public DbSet<User.User> Users { get; set; }
    public DbSet<User.Role> Roles { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User.User>().ToTable("User");
        modelBuilder.Entity<User.Role>().ToTable("Role");
    }
}