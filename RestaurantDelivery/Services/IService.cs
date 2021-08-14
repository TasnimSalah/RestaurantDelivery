using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantDelivery.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Add(T item);
        List<T> Update(T item);
        List<T> Delete(int id);
    }
}
