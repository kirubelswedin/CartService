namespace CartService.Domain.Models;

public class CartItem : BaseEntity
{
    public string ProductId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    
    public decimal TotalPrice => Price * Quantity;
}