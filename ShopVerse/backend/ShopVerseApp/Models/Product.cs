using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        public string? Category { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public string SKU { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}