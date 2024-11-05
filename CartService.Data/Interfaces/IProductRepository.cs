namespace CartService.Data.Interfaces;

public interface IProductRepository<T> : IBaseRepository<T>
{
    // Metod för att få produkter efter kategori
    // IEnumerable<T> GetProductsByCategory(string category); 
    //
    // // Metod för att uppdatera lagerstatus
    // void UpdateStock(int productId, int quantity); 
    //
    // // Metod för att hämta toppsäljande produkter
    // IEnumerable<T> GetTopSellingProducts(int count);
}