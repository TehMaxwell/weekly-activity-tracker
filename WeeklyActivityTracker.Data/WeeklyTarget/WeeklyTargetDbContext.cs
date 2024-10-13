/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 13/10/2024
 * 
 * DESCRIPTION: A database context for the Weekly Target database.
 */

using Microsoft.EntityFrameworkCore;

namespace WeeklyActivityTracker.Data.WeeklyTarget
{
    /// <summary>
    /// A database context for the Weekly Target database.
    /// </summary>
    public class WeeklyTargetDbContext : DbContext
    {
        // PROPERTIES
        /// <summary>
        /// A table for tracking the weekly target data.
        /// </summary>
        public DbSet<Models.WeeklyTarget.WeeklyTarget> WeeklyTargets { get; set; }

        // METHODS
        public WeeklyTargetDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        /// <summary>
        /// Configures options for the database and its relations when the model is created.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
