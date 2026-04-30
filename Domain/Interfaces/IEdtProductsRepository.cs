using Products_CleanArquitecture.Domain.Entities;

namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface IEdtProductsRepository
    {
        Task EditProductsById(Product product);
    }
}
