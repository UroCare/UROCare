using System;

namespace SHC.UROCare.UI
{
    public interface IPatientNodeView
    {
        /// <summary>
        /// Get month calendar value
        /// </summary>
        DateTime MonthCalendar { get; }

        /// <summary>
        /// Get GU Number from search text box;
        /// </summary>
        string GUNumberSearch { get; set; }

        /// <summary>
        /// Get or Set GU Number.
        /// </summary>
        string GUNumber { get; set; }
    }
}