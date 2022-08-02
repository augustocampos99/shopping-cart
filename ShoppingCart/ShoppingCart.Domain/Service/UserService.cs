using ShoppingCart.Domain.Entity;
using ShoppingCart.Domain.Interface.Repository;
using ShoppingCart.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
