using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ShopVerseApp.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        //RelationShips
        public string? UserId { get; set; }
        public virtual AppUser? User { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}