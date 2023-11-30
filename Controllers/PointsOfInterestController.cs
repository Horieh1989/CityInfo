using CityInfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]// for the whole controller
    [ApiController]// very important 
    public class PointsOfInterestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPointsOfIntrest(int cityid)
        { 
            var city= CitiesDataStore.current.Cities.FirstOrDefault(c=> c.Id==cityid);
            if (city == null)
            {
                return NotFound();

            }
            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{pointofintrestid}")]
        public ActionResult<IEnumerable<PointOfInterestDto>> GetPoinOfIntrest(int cityId, int pointOfIntrestId)
        {
            // Find the city id
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();

            }
            // Find pointOfIntrest
            var pointOfIntrest = city.PointsOfInterest.FirstOrDefault(c => c.Id == pointOfIntrestId);
            if (pointOfIntrest == null)
            {
                return NotFound();

            }
            return Ok(pointOfIntrest);


        }

    }
}
