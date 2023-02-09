using System;

namespace rest2.Infrastructure.Base;

public class DbEntity
{
    public int Id { get; set; }
    public virtual DateTime CreatedDate { get; set; }
}