namespace CartService.Domain.Models;

public class CartItem
{
    // public Guid CartItemId { get; set; }
    public string Id { get; set; } = null!;
    public string ProductName { get; set; } = null!;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}