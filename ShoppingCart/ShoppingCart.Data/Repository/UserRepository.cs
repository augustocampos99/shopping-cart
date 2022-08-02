using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySQLContext _context;
        public UserRepository(MySQLContext context)
        {
            _context = context;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
