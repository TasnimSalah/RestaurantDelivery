using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class CustomerOrders
    {
        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Order Order { get; set; }
        public Customer Customer { get; set; }
    }
}
