using CartService.Domain.Models;

namespace CartService.Domain.Factories;

public static class ProductFactory
{
    public static Product Create(ProductRequest productRequest)
    {
        try
        {
            var product = new Product
            {
                Name = productRequest.Name,
                Price = productRequest.Price,
                Quantity = productRequest.Quantity,
                Description = productRequest.Description,
            };
            return product;
        }
        catch 
        {
            return null!;
        }
    }
}