using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopVerseApp.Data;
using ShopVerseApp.DTOs.Product;
using ShopVerseApp.Models;
using ShopVerseApp.Repositories.Interfaces;

namespace ShopVerseApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Product> CreateAsync(CreateProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(UpdateProductDto productDto, int id)
        {
            throw new NotImplementedException();
        }
    }
}