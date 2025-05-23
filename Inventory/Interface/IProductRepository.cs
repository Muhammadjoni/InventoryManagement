﻿using Inventory.Models;

namespace Inventory.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task AdjustStockAsync(int productId, int adjustedQuantity, string reason, string adjustedBy = null);
    }
}