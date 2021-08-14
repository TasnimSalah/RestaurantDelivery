using Microsoft.AspNetCore.Mvc;
using RestaurantDelivery.Models;
using RestaurantDelivery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantDelivery.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {

        private readonly IService<Restaurant> _RestaurantService;

        public RestaurantController(IService<Restaurant> RestaurantService)
        {
            this._RestaurantService = RestaurantService;
        }


        // GET: <RestaurantController>
        [HttpGet]
        public IEnumerable<Restaurant> Get([FromQuery(Name = "restaurant")] string Restaurant,[FromQuery(Name = "city")] int CityId)
        {
            return _RestaurantService.GetAll().Where(r => r.CityId == CityId && r.Name.Contains(Restaurant));
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
