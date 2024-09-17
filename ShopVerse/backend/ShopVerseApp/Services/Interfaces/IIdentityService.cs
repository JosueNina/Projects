using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.DTOs.Account;
using ShopVerseApp.DTOs.Common;

namespace ShopVerseApp.Services.Interfaces
{
    public interface IIdentityService
    {
        public Task<ResponseDto<NewUserDto>> Login(LoginDto registerDto);
        public Task<ResponseDto<NewUserDto>> Register();
    }
}