using ShoppingCart.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Interface.Service
{
    public interface IUserService
    {
        List<User> GetAll();

    }
}
