using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class DeleteProductsRepository : IDeleteProductsRepository
    {
        private readonly AppDbContext _context;

        public DeleteProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteProductsById(int Id)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC DeleteProductsById @Id",
                new SqlParameter("@Id", Id)
            );
        }
    }
}
