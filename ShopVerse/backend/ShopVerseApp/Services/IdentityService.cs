using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopVerseApp.DTOs.Account;
using ShopVerseApp.DTOs.Common;
using ShopVerseApp.Models;
using ShopVerseApp.Services.Interfaces;

namespace ShopVerseApp.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenService _tokenService;

        public IdentityService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }
        public async Task<ResponseDto<NewUserDto>> Login(LoginDto loginDto)
        {
            var response = new ResponseDto<NewUserDto>();
            var user = await _userManager.Users.FirstOrDefaultAsync(e => e.UserName == loginDto.UserName);
            if (user == null)
            {
                response.Sucess = false;
                response.ErrorMessage = "Username not found and/or password incorret";
                return response;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var res = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!res.Succeeded)
            {
                response.Sucess = false;
                response.ErrorMessage = "Username not found and/or password incorret!";
                return response;
            }
            var userLogin = new NewUserDto
            {
                UserName = user.UserName ?? "",
                Email = user.Email ?? "",
                Token = _tokenService.CreateToken(user),
                Roles = roles
            };
            response.Sucess = true;
            response.Result = userLogin;
            return response;
        }

        public Task<ResponseDto<NewUserDto>> Register()
        {
            throw new NotImplementedException();
        }
    }
}