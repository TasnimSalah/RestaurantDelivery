using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public ICollection<OrderMeals> OrderMeals { get; set; }
        public ICollection<CustomerOrders> CustomerOrders { get; set; }
    }
}
