using Products_CleanArquitecture.Domain.Entities;

namespace Products_CleanArquitecture.Domain.Interfaces
{
    public interface ICustomersRepository
    {
        Task<List<Customers>> GetAllCustomers();
    }
}
