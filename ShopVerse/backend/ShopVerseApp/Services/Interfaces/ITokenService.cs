using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.Models;

namespace ShopVerseApp.Services.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}