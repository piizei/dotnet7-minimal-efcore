using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using rest2.Infrastructure.User;

namespace rest2.Features.Users;

public interface IGetUsersQuery
{
    public Task<IEnumerable<Users.User>> Execute();
}

public class GetUsersQuery: IGetUsersQuery
{
    
    IUserRepository UserRepository;
    private IMapper Mapper;

    public GetUsersQuery(IUserRepository userRepository, IMapper mapper)
    {
        UserRepository = userRepository;
        Mapper = mapper;
    }
    
    public async Task<IEnumerable<Users.User>> Execute()
    {
        return Mapper.Map<IEnumerable<User>>(await UserRepository.GetAll());
        
    }
}