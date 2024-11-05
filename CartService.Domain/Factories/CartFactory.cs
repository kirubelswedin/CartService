using CartService.Domain.Models;

namespace CartService.Domain.Factories;

public class CartFactory
{
    public Cart CreateCart(Product product, Cart cart)
    {
        return new Cart
        {
            UserId = cart.UserId,
            TotalPrice = cart.TotalPrice,
            Name = product.Name,
            Price = product.Price,
            Quantity = product.Quantity,
            Description = product.Description,
        };
    }

}