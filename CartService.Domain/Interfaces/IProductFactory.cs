using CartService.Domain.Models;

namespace CartService.Domain.Interfaces;

public interface IProductFactory
{
    Product Create(ProductRequest request);
}