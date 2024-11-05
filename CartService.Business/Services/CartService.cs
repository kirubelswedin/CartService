using CartService.Business.Interfaces;
using CartService.Data.Interfaces;
using CartService.Domain.Factories;
using CartService.Domain.Models;

namespace CartService.Business.Services;

public class CartService : ICartService
{
    public ResponseResult<Product> Add(Product entity)
    {
        throw new NotImplementedException();
    }

    ResponseResult<IEnumerable<Cart>> ICartService.GetAll()
    {
        throw new NotImplementedException();
    }

    ResponseResult<Cart> ICartService.GetOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Cart> DeleteOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Cart> Add(Product product, Cart cart)
    {
        throw new NotImplementedException();
    }

    ResponseResult<IEnumerable<Product>> IBaseRepository<Product>.GetAll()
    {
        throw new NotImplementedException();
    }

    ResponseResult<Product> IBaseRepository<Product>.GetOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Product> Delete(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }
}