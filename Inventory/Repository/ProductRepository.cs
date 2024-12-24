
using Inventory.InventoryDbContext;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryContext _context;

        public ProductRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AdjustStockAsync(int productId, int adjustedQuantity, string reason, string adjustedBy = null)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                throw new Exception("Product not found.");

            // Update stock quantity
            product.Quantity += adjustedQuantity;
            if (product.Quantity < 0)
                throw new Exception("Stock quantity cannot be negative.");

            _context.Products.Update(product);

            // Log adjustment
            var adjustment = new StockAdjustment
            {
                ProductId = productId,
                AdjustedQuantity = adjustedQuantity,
                Reason = reason,
                AdjustmentDate = DateTime.UtcNow,
                AdjustedBy = adjustedBy
            };
            _context.StockAdjustment.Add(adjustment);

            await _context.SaveChangesAsync();
        }
    }
}



/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * public class StockAdjustmentService
        {
            private readonly ApplicationDbContext _context;

            public StockAdjustmentService(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task AdjustStockAsync(int productId, int adjustedQuantity, string reason, string adjustedBy = null)
            {
                var product = await _context.Products.FindAsync(productId);
                if (product == null)
                    throw new Exception("Product not found.");

                // Update stock quantity
                product.StockQuantity += adjustedQuantity;
                if (product.StockQuantity < 0)
                    throw new Exception("Stock quantity cannot be negative.");

                _context.Products.Update(product);

                // Log adjustment
                var adjustment = new StockAdjustment
                {
                    ProductId = productId,
                    AdjustedQuantity = adjustedQuantity,
                    Reason = reason,
                    AdjustmentDate = DateTime.UtcNow,
                    AdjustedBy = adjustedBy
                };
                _context.StockAdjustments.Add(adjustment);

                await _context.SaveChangesAsync();
            }
        }
*/