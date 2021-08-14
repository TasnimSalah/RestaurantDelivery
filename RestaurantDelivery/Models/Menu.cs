using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class Menu
    {
        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }

        [ForeignKey("Meal")]
        public int MealId { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public decimal Price { get; set; }

        public Restaurant Restaurant { get; set; }
        public Meal Meal { get; set; }
    }
}
