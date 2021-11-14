using CRUD.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            if (HttpContext.Current.Session["restaurants"] == null)
            {
                _restaurants = new List<Restaurant>
                {
                    new Restaurant{Id = 1, Name = "Panago", Cuisine = CuisineType.Italian},
                    new Restaurant{Id = 2, Name = "Maybes Shawarma", Cuisine = CuisineType.MiddleEastern},
                    new Restaurant{Id = 3, Name = "Chipotle", Cuisine = CuisineType.Mexican}
                };

                HttpContext.Current.Session["restaurants"] = _restaurants;
            }
            _restaurants = (List<Restaurant>)HttpContext.Current.Session["restaurants"];
        }

        public Restaurant Add(Restaurant restaurant)
        {
            if (restaurant != null)
            {
                _restaurants.Add(restaurant);
                restaurant.Id = _restaurants.Count == 0 ? 1 : _restaurants.OrderByDescending(r => r.Id).First().Id + 1;
            }

            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            Restaurant existingRestaurant = Get(restaurant.Id);

            if (existingRestaurant != null)
            {
                existingRestaurant.Name = restaurant.Name;
                existingRestaurant.Cuisine = restaurant.Cuisine;
            }            

            return existingRestaurant;
        }

        public bool Delete(int id)
        {
            Restaurant existingRestaurant = Get(id);

            if (existingRestaurant != null)
            {
                return _restaurants.Remove(existingRestaurant);
            }
           
            return false;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }        
    }
}