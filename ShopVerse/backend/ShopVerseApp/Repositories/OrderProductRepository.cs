using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopVerseApp.Data;
using ShopVerseApp.Models;
using ShopVerseApp.Repositories.Interfaces;

namespace ShopVerseApp.Repositories
{
    public class OrderProductRepository : Repository<OrderProduct>, IOrderProductRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}