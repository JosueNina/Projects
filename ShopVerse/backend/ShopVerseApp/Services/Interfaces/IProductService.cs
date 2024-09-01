using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.DTOs.Product;
using ShopVerseApp.Models;

namespace ShopVerseApp.Services.Interfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProductsAsync();
        public Task<Product?> GetProductByIdAsync(int id);
        public Task<Product> CreateProductAsync(CreateProductDto productDto);
        public Task<Product?> UpdateProductAsync(UpdateProductDto productDto, int id);
        public Task<bool> DeleteProductAsync(int id);
    }
}