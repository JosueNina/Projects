using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.Data;
using ShopVerseApp.Models;
using ShopVerseApp.Repositories.Interfaces;

namespace ShopVerseApp.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}