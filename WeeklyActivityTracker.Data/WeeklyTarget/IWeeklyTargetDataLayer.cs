/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 12/10/2024
 * 
 * DESCRIPTION: A data layer for managing Weekly Target information.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyActivityTracker.Data.WeeklyTarget
{
    public interface IWeeklyTargetDataLayer
    {
        // METHODS
        /// <summary>
        /// Gets a list of Weekly Targets based upon the provided filters.
        /// </summary>
        /// <param name="top">The number of targets to return.</param>
        /// <param name="skip">The number of targets to skip.</param>
        /// <param name="earliestCompleteByTimestamp">The earlist timestamp to filter the Completed By timestamp for.</param>
        /// <param name="latestCompleteByTimestamp">The latest timestamp to filter the Completed By timestamp for.</param>
        /// <returns>A list of Weekly Targets that match the filter parameters.</returns>
        public Task<IEnumerable<Models.WeeklyTarget.WeeklyTarget>> GetWeeklyTargets(DateTime earliestCompleteByTimestamp, DateTime latestCompleteByTimestamp, int top = 0, int skip = 0);
    }
}
