using System;

namespace SHC.UROCare.UI
{
    public interface IIPDView : IView
    {
        /// <summary>
        /// Gets or set IPD Number value.
        /// </summary>
        string IPDNo { get; set; }

        /// <summary>
        /// Gets or sets admission date value.
        /// </summary>
        DateTime AdmissionDate { get; set; }

        /// <summary>
        /// Gets or sets discharge date value.
        /// </summary>
        DateTime DischargeDate { get; set; }

        /// <summary>
        /// Get or set provisional diagnosis value
        /// </summary>
        string ProvisionalDiagnosis { get; set; }

        /// <summary>
        /// Get or set complaints value.
        /// </summary>
        string Complaints { get; set; }

        /// <summary>
        /// Get or set final diagnosis value.
        /// </summary>
        string FinalDiagnosis { get; set; }

        /// <summary>
        /// Get or set advise value.
        /// </summary>
        string Advise { get; set; }

        /// <summary>
        /// Get or Set follow up date value.
        /// </summary>
        DateTime FollowupDate { get; set; }
    }    
}