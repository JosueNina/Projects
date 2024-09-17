using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.DTOs.Common;
using ShopVerseApp.DTOs.UserProfile;
using ShopVerseApp.Models;

namespace ShopVerseApp.Services.Interfaces
{
    public interface IUserProfileService
    {
        public Task<ResponseDto<UserProfile>> CreateUserProfile(CreateUserProfileDto userProfileDto);
    }
}