using ShoppingCart.Domain.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entity
{
    public class Cart
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string Note { get; set; }

        public int DeliveryAddressId { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public StatusCartEnum Status { get; set; }

        public DeliveryAddress Address { get; set; }

        public User User { get; set; }

        public List<CartItem> Items { get; set; }
    }
}
