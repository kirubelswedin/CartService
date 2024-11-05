using CartService.Data.Interfaces;

namespace CartService.Data.Services;

public class CartRepository<T> : BaseRepository<T>, ICartRepository<T>
{
    
}