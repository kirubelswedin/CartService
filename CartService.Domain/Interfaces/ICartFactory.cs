using CartService.Domain.Models;

namespace CartService.Domain.Interfaces;

public interface ICartFactory
{
    Cart CreateCart(string userId);
    CartItem CreateCartItem(Product product, int quantity);
}