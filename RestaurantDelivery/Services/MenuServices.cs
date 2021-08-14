using RestaurantDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Services
{
    public class MenuServices : IService<Menu>
    {
        private readonly ApplicationDbContext _db;

        public MenuServices(ApplicationDbContext db)
        {
            this._db = db;
        }

        public List<Menu> Add(Menu item)
        {
            throw new NotImplementedException();
        }

        public List<Menu> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAll()
        {
            return _db.Menus.ToList();
        }


        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> Update(Menu item)
        {
            throw new NotImplementedException();
        }
    }
}
