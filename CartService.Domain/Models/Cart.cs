namespace CartService.Domain.Models;

public class Cart : BaseEntity
{
    public string UserId { get; set; } = null!;
    private readonly List<CartItem> _items = [];
    public decimal TotalPrice => _items.Sum(item => item.TotalPrice);
    
}