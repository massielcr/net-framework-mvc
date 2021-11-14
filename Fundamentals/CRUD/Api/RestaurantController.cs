using CRUD.Data.Models;
using CRUD.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD.Api
{
    public class RestaurantController : ApiController
    {
        private IRestaurantData db;

        public RestaurantController()
        {
            db = new InMemoryRestaurantData();
        }

        // GET api/<controller>
        public IEnumerable<Restaurant> Get()
        {
            return db.GetAll();
        }

        // GET api/<controller>/5
        public Restaurant Get(int id)
        {
            return db.Get(id);
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {

        }
    }
}