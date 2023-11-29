using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CityInfo.Controllers
{
    [ApiController] //very important
    [Route("api/cities")]//for the whole controller
    public class CitiesController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.current.Cities);
        }

        [HttpGet("{id}")]
        //public JsonResult GetCity(int id) 
        //{ 
        //  return new JsonResult(CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == id));
        //}
        // we can write instead this:
        public ActionResult<CityDto> GetCity (int id)
        {
            //find city
            var cityToReturn=CitiesDataStore.current.Cities.FirstOrDefault (c => c.Id == id);
            if ( cityToReturn==null)

            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
