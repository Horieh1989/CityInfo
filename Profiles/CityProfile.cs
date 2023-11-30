using AutoMapper;

namespace CityInfo.Profiles
{
    public class CityProfile: Profile
    { 
        // creat constructor
        public CityProfile() 
        {
            CreateMap<Entities.City, Models.CityWithoutPointOfIntrestDto>();
        }
    }
}
