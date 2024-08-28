using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.DTOs.Product;
using ShopVerseApp.Models;

namespace ShopVerseApp.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsync();
        public Task<Product?> GetByIdAsync(int id);
        public Task<Product> CreateAsync(CreateProductDto productDto);
        public Task<Product> UpdateAsync(UpdateProductDto productDto, int id);
        public Task<Product> DeleteAsync(int id);

    }
}