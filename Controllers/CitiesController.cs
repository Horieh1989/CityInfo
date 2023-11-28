using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CityInfo.Controllers
{
    [ApiController]//very important
    public class CitiesController:ControllerBase
    {
        [HttpGet("api/Cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object> { 
            
                new{id=1,name="New York City"},
                new { id = 2, name = "Antwerp" }
            });

        }
           
        
    }
}
