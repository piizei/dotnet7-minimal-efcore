using rest2.Infrastructure.User;

namespace rest2.Infrastructure;

public static class DbInitializer
{
    public static void Initialize(IDbContext context)
    {
        context.Database.EnsureCreated();
        if (context.Users.Any())
        {
            return;   
        }

        var roles = new[]
        {
            new Role { Name = "Admin" },
            new Role { Name = "User" },
            new Role { Name = "Anonymous" }
        };
        foreach (var s in roles)
        {
            context.Roles.Add(s);
        }
        context.SaveChanges();

        var user = new[]
        {
            new User.User { Firstname = "First1", Lastname = "Last1", Roles = new[] {roles.First()}},
            new User.User { Firstname = "First2", Lastname = "Last2", Roles = new[] {roles.Last()} }
        };
        foreach (var u in user)
        {
            context.Users.Add(u);
        }
        context.SaveChanges();
    }

}