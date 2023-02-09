using AutoMapper;

namespace rest2.Features.Users;

public class UserProfile: Profile
{
    public UserProfile()
    {
        CreateMap<rest2.Infrastructure.User.User, User>()
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.Firstname + " " + src.Lastname)
            );
    }
}