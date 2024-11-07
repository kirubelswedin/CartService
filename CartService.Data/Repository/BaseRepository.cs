using CartService.Data.Interfaces;
using CartService.Domain.Factories;
using CartService.Domain.Models;

namespace CartService.Data.Services;

public abstract class BaseRepository<T> : IBaseRepository<T>
{
    private readonly List<T> _items = [];
    
    public virtual ResponseResult<T> Add(T entity)
    {
        _items.Add(entity);
        return ResponseFactory<T>.Success(entity);
    }
    
    public virtual ResponseResult<IEnumerable<T>> GetAll()
    {
        return ResponseFactory<IEnumerable<T>>.Success(_items);
    }
    
    public virtual ResponseResult<T> GetOne(Func<T, bool> predicate)
    {
        var entity = _items.FirstOrDefault(predicate);
        if (entity != null)
        {
            return ResponseFactory<T>.Success(entity);
        }
        return ResponseFactory<T>.NotFound(entity!);
    }

    // public virtual ResponseResult<T> Update(T entity, Func<T, bool> predicate)
    // {
    //     var existingEntity = _items.FirstOrDefault(predicate);
    //     if (existingEntity != null)
    //     {
    //         var index = _items.IndexOf(existingEntity); 
    //         _items[index] = entity; 
    //         return ResponseFactory<T>.Success(entity);
    //     } 
    //     return ResponseFactory<T>.NotFound(entity!);
    // }

    public virtual ResponseResult<T> Delete(Func<T, bool> predicate)
    {
        var entity = _items.FirstOrDefault(predicate); 
        if (entity != null) 
        { 
            _items.Remove(entity); 
            return ResponseFactory<T>.Success(entity); 
        } 
        return ResponseFactory<T>.NotFound(entity!);
    }
}