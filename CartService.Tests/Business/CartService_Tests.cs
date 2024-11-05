using CartService.Domain.Factories;
using CartService.Domain.Models;

namespace CartService.Tests.Business;

public class CartService_Tests
{
    private readonly CartService.Business.Services.CartService _cartService;
    

    public CartServiceTests()
    {
        _cartService = new CartService.Business.Services.CartService();
        
    }

    [Fact]
    public void Add_ValidProductAndCart_ReturnsSuccessResult()
    {
        // Arrange
        var product = new Product
        {
            Name = "TestProduct",
            Price = 100,
            Quantity = 1,
            Description = "Test Description"
        };

        var cart = new Cart
        {
            UserId = "testUser",
            TotalPrice = 0,
            Name = "",
            Price = 0,
            Quantity = 0,
            Description = ""
        };

        // Act
        var result = _cartService.Add(product, cart);

        // Assert
        Assert.True(result.Success);
        Assert.NotNull(result.Data);
        Assert.Equal(product.Name, result.Data.Name);
        Assert.Equal(product.Price, result.Data.Price);
    }
}