using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.Data;
using ShopVerseApp.DTOs.Product;
using ShopVerseApp.Models;
using ShopVerseApp.Repositories.Interfaces;
using ShopVerseApp.Services.Interfaces;

namespace ShopVerseApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;
        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }
        public Task<Product> CreateProductAsync(CreateProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _productRepo.GetAllAsync();
            return products;
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(UpdateProductDto productDto, int id)
        {
            throw new NotImplementedException();
        }
    }
}