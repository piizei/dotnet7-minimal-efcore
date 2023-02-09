using System.Collections.Generic;
using rest2.Infrastructure.Base;

namespace rest2.Infrastructure.User;

public class User: DbEntity
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int languageId { get; set; }
    public IEnumerable<Role> Roles { get; set; }
}
