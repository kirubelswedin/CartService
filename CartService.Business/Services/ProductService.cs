using CartService.Business.Interfaces;
using CartService.Data.Interfaces;
using CartService.Domain.Models;

namespace CartService.Business.Services;

public class ProductService : IProductService
{
    public ResponseResult<Product> Add(Product entity)
    {
        throw new NotImplementedException();
    }

    ResponseResult<IEnumerable<Product>> IProductService.GetAll()
    {
        throw new NotImplementedException();
    }

    ResponseResult<Product> IProductService.GetOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Product> DeleteOne(Func<Product, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public ResponseResult<Product> Add(ProductRequest productRequest)
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