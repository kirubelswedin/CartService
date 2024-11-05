using CartService.Data.Interfaces;
using CartService.Domain.Models;

namespace CartService.Business.Interfaces;

public interface ICartService : IBaseRepository<Product>
{
    public ResponseResult<Cart> Add(Product product, Cart cart);
    public ResponseResult<IEnumerable<Cart>> GetAll();
    public ResponseResult<Cart> GetOne(Func<Product, bool> predicate);
    // public ResponseResult<Cart> UpdateOne(Func<Product, bool> predicate, Cart updateCart);
    public ResponseResult<Cart> DeleteOne(Func<Product, bool> predicate);
    
    
}