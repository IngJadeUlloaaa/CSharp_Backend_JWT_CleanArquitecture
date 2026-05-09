using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class DeleteCustomersRepository : IDeleteCustomersRepository
    {
        private readonly AppDbContext _context;
        public DeleteCustomersRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteCustomersById(int Id)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC DeleteCustomersById @Id",
                new SqlParameter("@Id", Id)
            );
        }
    }
}