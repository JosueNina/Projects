using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public string OrderStatus { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }
        [Required]
        public string ShippingAddress { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        //Relationship
        public int UserProfileId { get; set; }
        public UserProfile? User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}