namespace CartService.Domain.Models;

public class Product
{
    // public Guid Id { get; set; }
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string? Description { get; set; } 
    // public string Category { get; set; } = null!;
}