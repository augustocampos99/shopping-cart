using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();

    }
}
