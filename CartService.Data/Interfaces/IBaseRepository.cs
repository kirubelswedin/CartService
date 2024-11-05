using CartService.Domain.Models;

namespace CartService.Data.Interfaces;

public interface IBaseRepository<T>
{
    ResponseResult<T> Add(T entity);
    ResponseResult<IEnumerable<T>> GetAll();
    ResponseResult<T> GetOne(Func<T, bool> predicate);
    // ResponseResult<T> Update(T entity, Func<T, bool> predicate); 
    ResponseResult<T> Delete(Func<T, bool> predicate);
}