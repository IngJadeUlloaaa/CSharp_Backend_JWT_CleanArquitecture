using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class EditCustomersRepository : IEditCustomers
    {
        private readonly AppDbContext _context;

        public EditCustomersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task IEditCustomersById(Customers customers)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC EditCustomers @Id, @Username, @LastName, @Email, @Phone",
                new SqlParameter("@Id", customers.Id),
                new SqlParameter("@Username", customers.Username),
                new SqlParameter("@LastName", customers.LastName),
                new SqlParameter("@Email", customers.Email),
                new SqlParameter("@Phone", customers.Phone)
            );
        }
    }
}
