using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entity
{
    public class CartItem
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public int CartId { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public Cart Cart { get; set; }
    }
}
