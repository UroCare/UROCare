using System;

namespace SHC.UROCare.UI
{
    public interface ITreatmentView : IView
    {
        /// <summary>
        /// Gets or set treatment date value.
        /// </summary>
        DateTime TreatmentDate { get; set; }

        /// <summary>
        /// Gets or sets treatment value.
        /// </summary>
        string TreatmentGiven { get; set; }
    }    
}