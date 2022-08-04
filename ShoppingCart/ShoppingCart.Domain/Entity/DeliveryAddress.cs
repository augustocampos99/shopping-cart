using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain.Entity
{
    public class DeliveryAddress
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
