using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class OrderMeals
    {
        [ForeignKey("Meal")]
        public int MealId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Meal Meal { get; set; }
        public Order Order { get; set; }
    }
}
