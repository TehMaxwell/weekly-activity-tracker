/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 12/10/2024
 * 
 * DESCRIPTION: An API Controller that manages Weekly Target information.
 */

using Microsoft.AspNetCore.Mvc;
using WeeklyActivityTracker.Models.WeeklyTarget;

namespace WeeklyActivityTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeeklyTargetController : ControllerBase
    {
        // PROPERTIES
        private readonly ILogger<WeeklyTargetController> _logger;

        // METHODS
        public WeeklyTargetController(ILogger<WeeklyTargetController> logger)
        {
            _logger = logger;
        }
        
        /// <summary>
        /// Get request, gets a set of targets based upon the given filter conditions.
        /// </summary>
        /// <param name="top">The number of targets to return.</param>
        /// <param name="skip">The number of targets to skip.</param>
        /// <returns>Returns a list of targets that meet the given filter criteria.</returns>
        public IEnumerable<WeeklyTarget> Get(DateTime earliestTimestamp, DateTime latestTimestamp, int top = 0, int skip = 0)
        {
            
        }
    }
}
