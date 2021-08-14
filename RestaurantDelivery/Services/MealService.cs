using RestaurantDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Services
{
    public class MealService : IService<Meal>
    {
        private readonly ApplicationDbContext _db;

        public MealService(ApplicationDbContext db)
        {
            this._db = db;
        }
        public List<Meal> Add(Meal item)
        {
            _db.Meals.Add(item);
            _db.SaveChanges();
            return _db.Meals.ToList();
        }

        public List<Meal> Delete(int id)
        {
            Meal _Meal = _db.Meals.FirstOrDefault(s => s.Id == id);
            _db.Remove(_Meal);
            _db.SaveChanges();
            return _db.Meals.ToList();
        }

        public List<Meal> GetAll()
        {
            return _db.Meals.ToList();
        }

        public Meal GetById(int id)
        {
            return _db.Meals.FirstOrDefault(m => m.Id == id);
        }

        public List<Meal> Update(Meal item)
        {
            Meal _Meal = _db.Meals.FirstOrDefault(s => s.Id == item.Id);
            _Meal.Name = item.Name;
            _Meal.Description = item.Description;
            _Meal.Photo = item.Photo;
            _db.SaveChanges();
            return _db.Meals.ToList();
        }
    }
}
