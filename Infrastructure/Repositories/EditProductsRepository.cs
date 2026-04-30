using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class EditProductsRepository : IEdtProductsRepository
    {
        private readonly AppDbContext _context;

        public EditProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task EditProductsById(Product product)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC EditProductsById @Id, @Name, @Category, @Price, @Stock",
                new SqlParameter("@Id", product.Id),
                new SqlParameter("@Name", product.Name),
                new SqlParameter("@Category", product.Category),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@Stock", product.Stock)
            );
        }
    }
}