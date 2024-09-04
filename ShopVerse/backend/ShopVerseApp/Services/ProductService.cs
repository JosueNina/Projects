using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public async Task<Product> CreateProductAsync(CreateProductDto productDto)
        {
            var product = await _productRepo.CreateAsync(_mapper.Map<Product>(productDto));
            return product;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null)
            {
                return false;
            }
            var isDeleted = await _productRepo.DeleteAsync(product);
            return isDeleted;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var products = await _productRepo.GetMany().ToListAsync();
            return products;
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            return product;
        }

        public async Task<Product?> UpdateProductAsync(UpdateProductDto productDto, int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return null;
            //_mapper.Map(product, productDto);
            product.Description = productDto.Description;
            product.Price = productDto.Price;
            product.ProductName = productDto.ProductName;
            product.Category = productDto.Category;
            product.ImageUrl = productDto.ImageUrl;
            product.SKU = productDto.SKU;
            product.Stock = productDto.Stock;
            await _productRepo.UpdateAsync(product);
            return product;
        }
    }
}