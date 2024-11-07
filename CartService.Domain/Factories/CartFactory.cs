using CartService.Domain.Interfaces;
using CartService.Domain.Models;

namespace CartService.Domain.Factories;

public class CartFactory : ICartFactory
{
    public Cart CreateCart(string userId)
    {
        return new Cart
        {
            UserId = userId
        };
    }
    
    public CartItem CreateCartItem(Product product, int quantity)
    {
        return new CartItem
        {
            ProductId = product.Id,
            Name = product.Name,
            Price = product.Price,
            Quantity = quantity
        };
    }
}