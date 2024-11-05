using CartService.Domain.Models;

namespace CartService.Domain.Factories;

public class CartFactory
{
    public Cart CreateCart(Product product, string userId)
    {
        return new Cart
        {
            UserId = userId,
            ProductName = product.Name,
            
        };
    }

}