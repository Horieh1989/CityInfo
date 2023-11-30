using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CityInfo.Models;

namespace CityInfo.Data
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext (DbContextOptions<CityInfoContext> options)
            : base(options)
        {
        }

        public DbSet<CityInfo.Models.PointOfInterestDto> PointOfInterestDto { get; set; } = default!;
    }
}
