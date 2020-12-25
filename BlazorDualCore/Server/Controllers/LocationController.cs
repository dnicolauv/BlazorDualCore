using BlazorDualCore.Shared;
using BlazorDualCore.Shared.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BlazorDualCore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;
        private readonly LocationService _locationService;

        public LocationController(ILogger<LocationController> logger, LocationService locationService)
        {
            _logger = logger;
            _locationService = locationService;
        }

        [HttpGet]
        public IEnumerable<Location> Get(string search = null)
        {
            return _locationService.Get(search);
        }
    }
}
