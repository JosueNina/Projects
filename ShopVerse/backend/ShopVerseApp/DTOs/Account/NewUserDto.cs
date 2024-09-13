using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopVerseApp.DTOs.Account
{
    public class NewUserDto
    {
        public string UserName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Token { get; set; } = String.Empty;
        public IList<string> Roles { get; set; } = new List<string>();
    }
}