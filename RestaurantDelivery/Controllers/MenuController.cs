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
    public class MenuController : ControllerBase
    {


        private readonly IService<Menu> _MenuService;

        public MenuController(IService<Menu> MenuService)
        {
            this._MenuService = MenuService;
        }




        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        //get by restaurant id
        [HttpGet("{id}")]
        public IEnumerable<Meal> Get(int id)
        {
            return _MenuService.GetAll().Where(m => m.RestaurantId == id).Select(m => m.Meal).ToList();
        }

        // POST api/<MenuController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
