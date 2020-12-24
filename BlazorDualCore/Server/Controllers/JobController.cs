using BlazorDualCore.Shared;
using BlazorDualCore.Shared.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BlazorDualCore.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly ILogger<JobController> _logger;
        private readonly JobService _jobService;

        public JobController(ILogger<JobController> logger, JobService jobService)
        {
            _logger = logger;
            _jobService = jobService;
        }

        [HttpGet]
        public IEnumerable<Job> Get(string search = null)
        {
            return _jobService.Get(search);
        }
    }
}
