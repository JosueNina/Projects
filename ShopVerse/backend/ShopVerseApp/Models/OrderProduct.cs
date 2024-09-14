using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceAtOrder { get; set; }

        //Relationships
        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}