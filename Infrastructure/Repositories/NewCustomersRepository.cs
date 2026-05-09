using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class NewCustomersRepository : INewCustomersRepoistory
    {
        private readonly AppDbContext _context;

        public NewCustomersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task INewCustomers(Customers customers)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC AddNewCustomers @Username, @LastName, @Email, @Phone",
                new SqlParameter("@Username", customers.Username),
                new SqlParameter("@LastName", customers.LastName),
                new SqlParameter("@Email", customers.Email),
                new SqlParameter("@Phone", customers.Phone)
            );
        }
    }
}
