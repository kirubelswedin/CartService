namespace CartService.Domain.Models;

public class ProductRequest 
{
    public string Name { get; set; } = null!;
    public decimal Price { get; private set; }
    public int Quantity { get; set; }
    public string? Description { get; set; } 
}