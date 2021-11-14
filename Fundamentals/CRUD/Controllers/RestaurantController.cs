using CRUD.Data.Models;
using CRUD.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantData db; 

        public RestaurantController()
        {
            db = new InMemoryRestaurantData();
        }

        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurants = db.GetAll();

            return View(restaurants);
        }

        public ActionResult Details(int id)
        {
            Restaurant restaurant = db.Get(id);

            return View(restaurant);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Add(restaurant);
                return RedirectToAction("Index");
            }
            
            return View(restaurant);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Restaurant restaurant = db.Get(id);

            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            db.Update(restaurant);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Restaurant restaurant = db.Get(id);

            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }
}