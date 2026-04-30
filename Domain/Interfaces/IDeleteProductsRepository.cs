using Products_CleanArquitecture.Domain.Entities;

namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface IDeleteProductsRepository
    {
        Task DeleteProductsById(int Id);
    }
}
