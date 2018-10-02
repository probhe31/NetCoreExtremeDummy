using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Controllers
{

    [Route("api/cities")]
    public class CitiesController : Controller
    {
        /*[HttpGet()]
        public JsonResult GetCities()
        {*/
            /*return new JsonResult(new List<Object>()
            {
                new { id=1, Name="New York City"},
                new { id=2, Name="Antwerp"},
            });*/

            //return new JsonResult(CitiesDataStore.Current.Cities);
        //}

        [HttpGet()]
        public IActionResult GetCities()
        {
            /*var temp = new JsonResult(CitiesDataStore.Current.Cities);
            temp.StatusCode = 200;
            return temp;*/

            return Ok(CitiesDataStore.Current.Cities);
        }

        
        /*[HttpGet("{id}")] 
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }*/

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
