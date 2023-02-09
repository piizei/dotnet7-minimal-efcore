using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace rest2.Features.Users;

public class UserModule: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/users", (IGetUsersQuery getUsersQuery, HttpResponse resp) => 
                getUsersQuery.Execute())
            .Produces<IEnumerable<Users.User>>(200);
    }
}