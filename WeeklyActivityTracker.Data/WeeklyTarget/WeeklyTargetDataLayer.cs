/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 13/10/2024
 * 
 * DESCRIPTION: A data layer for managing Weekly Target information.
 */

using Microsoft.EntityFrameworkCore;

namespace WeeklyActivityTracker.Data.WeeklyTarget
{
    /// <summary>
    /// A data layer for managing Weekly Target information.
    /// </summary>
    public class WeeklyTargetDataLayer : IWeeklyTargetDataLayer
    {
        // PROPERTIES
        private readonly WeeklyTargetDbContext _dbContext;

        // METHODS
        public WeeklyTargetDataLayer(WeeklyTargetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Models.WeeklyTarget.WeeklyTarget>> GetWeeklyTargets(DateTime earliestCompleteByTimestamp, DateTime latestCompleteByTimestamp, int top = 0, int skip = 0)
        {
            IQueryable<Models.WeeklyTarget.WeeklyTarget> query = _dbContext.WeeklyTargets
                .Where(weeklyTarget => weeklyTarget.TargetCompleteByTimestamp >= earliestCompleteByTimestamp && weeklyTarget.TargetCompleteByTimestamp <= latestCompleteByTimestamp)
                .AsNoTracking();

            // Setting up query based upon input parameters
            if (top > 0) query.Take(top);
            if (skip > 0) query.Skip(skip);

            return await query.ToListAsync();
        }
    }
}
