using Products_CleanArquitecture.Domain.Entities;
using Products_CleanArquitecture.Domain.Interfaces;
using Products_CleanArquitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Products_CleanArquitecture.Infrastructure.Repositories
{
    public class NewProductsRepository : INewProductsRepository
    {
        private readonly AppDbContext _context;

        public NewProductsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddNewProductInterface(Product product)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC AddProducts @Name, @Category, @Price, @Stock",
                new SqlParameter("@Name", product.Name),
                new SqlParameter("@Category", product.Category),
                new SqlParameter("@Price", product.Price),
                new SqlParameter("@Stock", product.Stock)
            );
        }
    }
}