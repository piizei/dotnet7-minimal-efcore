using System.Collections.Generic;
using System.Threading.Tasks;

namespace rest2.Infrastructure.Base;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAll();
    T GetByID(object id);
    void Insert(T entity);
    void Delete(object id);
    void Delete(T entity);
    void Update(T entity);
}