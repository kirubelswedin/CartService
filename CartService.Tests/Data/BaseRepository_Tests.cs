using CartService.Data.Services;
using CartService.Domain.Models;

namespace CartService.Tests.Data;

public class BaseRepository_Tests
{
    private class TestRepository : BaseRepository<Product>
    {
    }

    private readonly TestRepository _repository;

    public BaseRepository_Tests()
    {
        _repository = new TestRepository(); 
    }

    [Fact]
    public void Add_ValidProduct_ReturnsSuccessResult()
    {
        var product = new Product
        {
            Name = "TestProduct",
            Price = 100,
            Quantity = 1,
            Description = "Test Description"
        };

        var result = _repository.Add(product);


        Assert.True(result.Success);
        Assert.Equal(product, result.Data);
    }
    
    [Fact]
    public void GetAll_ReturnsAllItems()
    {

        var product1 = new Product { Name = "Product1", Price = 50, Quantity = 2, Description = "Description 1" };
        var product2 = new Product { Name = "Product2", Price = 75, Quantity = 3, Description = "Description 2" };
        _repository.Add(product1);
        _repository.Add(product2);


        var result = _repository.GetAll();


        Assert.True(result.Success);
        Assert.Equal(2, result.Data!.Count()); 
        Assert.Contains(result.Data!, p => p.Name == "Product1");
        Assert.Contains(result.Data!, p => p.Name == "Product2");
    }

    [Fact]
    public void GetOne_ValidPredicate_ReturnsSuccessResult()
    {

        var product = new Product { Name = "TestProduct", Price = 100, Quantity = 1, Description = "Test Description" };
        _repository.Add(product);


        var result = _repository.GetOne(p => p.Name == "TestProduct");


        Assert.True(result.Success);
        Assert.Equal("TestProduct", result.Data!.Name);
    }


    [Fact]
    public void Delete_ValidPredicate_ReturnsSuccessResult()
    {
        var product = new Product { Name = "TestProduct", Price = 100, Quantity = 1, Description = "Test Description" };
        _repository.Add(product);

        var result = _repository.Delete(p => p.Name == "TestProduct");

        Assert.True(result.Success);
        Assert.Equal("TestProduct", result.Data!.Name);
    }
}