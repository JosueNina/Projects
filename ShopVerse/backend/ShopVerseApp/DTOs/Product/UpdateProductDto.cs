using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.DTOs.Product
{
    public class UpdateProductDto
    {
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Category { get; set; }
        public string? ImageUrl { get; set; }
        public string SKU { get; set; } = string.Empty;
    }
}