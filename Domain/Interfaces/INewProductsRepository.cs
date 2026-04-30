using Products_CleanArquitecture.Domain.Entities;

namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface INewProductsRepository
    {
        Task AddNewProductInterface(Product product);
    }
}
