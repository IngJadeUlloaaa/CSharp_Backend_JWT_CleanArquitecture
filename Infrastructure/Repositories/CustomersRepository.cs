using Microsoft.EntityFrameworkCore;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Infrastructure.Persistence;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly AppDbContext _context;

        public CustomersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customers>> GetAllCustomers()
        {
            return await _context.Customers.FromSqlRaw("EXEC GetAllCustomers").ToListAsync();
        }
    }
}
