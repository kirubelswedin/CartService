using CartService.Data.Interfaces;
using CartService.Domain.Models;

namespace CartService.Business.Interfaces;

public interface IProductService : IBaseRepository<Product>
{
    public ResponseResult<Product> Add(ProductRequest productRequest);
    public ResponseResult<IEnumerable<Product>> GetAll();
    public ResponseResult<Product> GetOne(Func<Product, bool> predicate);
    // public ResponseResult<Product> UpdateOne(Func<Product, bool> predicate, Product updateProduct);
    public ResponseResult<Product> DeleteOne(Func<Product, bool> predicate);
}