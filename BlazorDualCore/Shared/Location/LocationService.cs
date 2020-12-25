using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDualCore.Shared.Data
{
    public class LocationService
    {
        public LocationService()
        {
        }

        public IEnumerable<Location> Get(string search = null)
        {
            var locations = new List<Location>()
            {
                new Location()
                {
                    Name = "United Kingdom",
                    Id = Guid.NewGuid(),
                },
                new Location()
                {
                    Name = "Spain",
                    Id = Guid.NewGuid(),
                },
                new Location()
                {
                    Name = "Germany",
                    Id = Guid.NewGuid(),
                },
                new Location()
                {
                    Name = "Netherlands",
                    Id = Guid.NewGuid(),
                },
                new Location()
                {
                    Name = "Switzerland",
                    Id = Guid.NewGuid(),
                },new Location()
                {
                    Name = "France",
                    Id = Guid.NewGuid(),
                },
            };

            if (String.IsNullOrEmpty(search))
                return locations.OrderBy(x => x.Name);
            return locations.Where(x => x.Name.ToLower().StartsWith(search.ToLower()) || x.Name.ToLower().Contains(search.ToLower())).ToList().OrderBy(x => x.Name);
        }    
    }
}
