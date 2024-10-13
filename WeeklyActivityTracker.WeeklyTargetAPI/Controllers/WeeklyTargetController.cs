/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 12/10/2024
 * 
 * DESCRIPTION: An API Controller that manages Weekly Target information.
 */

using Microsoft.AspNetCore.Mvc;
using WeeklyActivityTracker.Data.WeeklyTarget;
using WeeklyActivityTracker.Models.WeeklyTarget;

namespace WeeklyActivityTracker.Controllers
{
    /// <summary>
    /// An API Controller that manages Weekly Target information.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class WeeklyTargetController : ControllerBase
    {
        // PROPERTIES
        private readonly ILogger<WeeklyTargetController> _logger;

        private readonly IWeeklyTargetDataLayer weeklyTargetDataLayer;

        // METHODS
        public WeeklyTargetController(ILogger<WeeklyTargetController> logger, IWeeklyTargetDataLayer weeklyTargetDataLayer)
        {
            _logger = logger;

            this.weeklyTargetDataLayer = weeklyTargetDataLayer;
        }

        /// <summary>
        /// Get request, gets a set of targets based upon the given filter conditions.
        /// </summary>
        /// <param name="top">The number of targets to return.</param>
        /// <param name="skip">The number of targets to skip.</param>
        /// <param name="earliestCompleteByTimestamp">The earlist timestamp to filter the Completed By timestamp for.</param>
        /// <param name="latestCompleteByTimestamp">The latest timestamp to filter the Completed By timestamp for.</param>
        /// <returns>Returns a list of targets that meet the given filter criteria.</returns>
        [HttpGet()]
        public async Task<IEnumerable<WeeklyTarget>> Get(DateTime earliestCompleteByTimestamp, DateTime latestCompleteByTimestamp, int top = 0, int skip = 0)
        {
            IEnumerable<WeeklyTarget> weeklyTargets = await weeklyTargetDataLayer.GetWeeklyTargets(earliestCompleteByTimestamp, latestCompleteByTimestamp, top, skip);

            return weeklyTargets;
        }
    }
}
