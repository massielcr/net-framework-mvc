using System.Collections.Generic;
using CRUD.Data.Models;

namespace CRUD.Data.Services
{
    internal interface IRestaurantData
    {
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
        bool Delete(int id);
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);        
    }
}
