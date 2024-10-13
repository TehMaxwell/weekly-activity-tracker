/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 13/10/2024
 * 
 * DESCRIPTION: A class for automatic application of EntityFramework migrations for the WeeklyTarget database.
 */

using Microsoft.EntityFrameworkCore;
using WeeklyActivityTracker.Data.WeeklyTarget;

namespace WeeklyActivityTracker.WeeklyTargetAPI.InitDatabase
{
    /// <summary>
    /// A class for automatic application of EntityFramework migrations for the WeeklyTarget database
    /// </summary>
    public class MigrationApplicator
    {
        // PROPERTIES
        private readonly WeeklyTargetDbContext _dbContext;

        // METHODS
        public MigrationApplicator(WeeklyTargetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Automatically applies the Entity Framework database migrations to the database
        /// </summary>
        public void ApplyMigrations()
        {
            _dbContext.Database.Migrate();      // Automatically applies the database migrations, no migrations will occur if the database is up to date
        }
    }
}
