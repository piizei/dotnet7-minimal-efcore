using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace rest2.Infrastructure;


public interface IDbContext
{
    public DbSet<User.User> Users { get; set; }
    public DbSet<User.Role> Roles { get; set; }
    public DatabaseFacade Database { get; }
    public int SaveChanges();
    public EntityEntry Entry([NotNull] object entity);
    public EntityEntry<TEntity> Entry<TEntity>([NotNullAttribute] TEntity entity) where TEntity : class;
}
