/*
 * AUTHOR: Sam Maxwell
 * DATE CREATED: 12/10/2024
 * 
 * DESCRIPTION: A model that describes Weekly Target information.
 */

using System.ComponentModel.DataAnnotations;

namespace WeeklyActivityTracker.Models.WeeklyTarget
{
    public class WeeklyTarget
    {
        // PROPERTIES
        /// <summary>
        /// The unique identifier of the Weekly Target entry.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the Weekly Target.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// A description of the Weekly Target.
        /// </summary>
        public string TargetDecription { get; set; }

        /// <summary>
        /// The DateTime that the Target was created at.
        /// </summary>
        public DateTime TargetCreatedTimestamp { get; set; }

        /// <summary>
        /// The DateTime that the Target must be completed at.
        /// </summary>
        public DateTime TargetCompleteByTimestamp { get; set; }

        /// <summary>
        /// The DateTime that the Targt was completed at.
        /// </summary>
        public DateTime TargetCompletedTimestamp { get; set; }
    }
}
