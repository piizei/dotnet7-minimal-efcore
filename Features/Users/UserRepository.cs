using rest2.Infrastructure.Base;

namespace rest2.Infrastructure.User;

public interface IUserRepository: IGenericRepository<User>
{
    
}

public class UserRepository: GenericRepository<User>, IUserRepository
{
    public UserRepository(MSSqlDbContext context): base(context)
    {

    }
}