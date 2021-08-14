using RestaurantDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Services
{
    public class RestaurantServices : IService<Restaurant>
    {
        private readonly ApplicationDbContext _db;

        public RestaurantServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Restaurant> Add(Restaurant item)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAll()
        {
            return _db.Restaurants.ToList();
        }

        public Restaurant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> Update(Restaurant item)
        {
            throw new NotImplementedException();
        }

    }
}
