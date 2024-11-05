namespace CartService.Domain.Models;

public class Cart
{
    // public Guid Id { get; set; }
    public string Id { get; set; }
    public string UserId { get; set; }
    // public List<CartItem> Items { get; set; } = new List<CartItem>();
    public decimal TotalPrice { get; set; }
    
    
}