using Products_CleanArquitecture.Domain.Entities;

namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
    }
}
