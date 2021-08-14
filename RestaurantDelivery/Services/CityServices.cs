using RestaurantDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Services
{
    public class CityServices : IService<City>
    {
        private readonly ApplicationDbContext _db;

        public CityServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<City> Add(City item)
        {
            throw new NotImplementedException();
        }

        public List<City> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return _db.Cities.ToList();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<City> Update(City item)
        {
            throw new NotImplementedException();
        }
    }
}
