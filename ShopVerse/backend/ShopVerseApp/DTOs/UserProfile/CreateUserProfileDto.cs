using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.DTOs.UserProfile
{
    public class CreateUserProfileDto
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
    }
}