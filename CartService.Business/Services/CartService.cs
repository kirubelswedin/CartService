
using CartService.Data.Interfaces;

namespace CartService.Business.Services;

public class CartService<T>(ICartRepository<T> cartRepository)
{
    private ICartRepository<T> _cartRepository = cartRepository;
}

