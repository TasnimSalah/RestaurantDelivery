using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^(01)[0-9]{9}$" , ErrorMessage = "Invalid Number")]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        public ICollection<CustomerOrders> CustomerOrders { get; set; }
    }
}
