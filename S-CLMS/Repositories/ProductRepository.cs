using Microsoft.EntityFrameworkCore;
using S_CLMS.Data;
using S_CLMS.Models;

namespace S_CLMS.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SclmsContext _context;

        public ProductRepository(SclmsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync() => await _context.Products.ToListAsync();
        public async Task<Product> GetProductByIdAsync(int id) => await _context.Products.FindAsync(id);
        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }

}
