using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.Data;
using ShopVerseApp.Models;
using ShopVerseApp.Repositories.Interfaces;

namespace ShopVerseApp.Repositories
{
    public class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository
    {
        private readonly ApplicationDbContext _context;
        public UserProfileRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}