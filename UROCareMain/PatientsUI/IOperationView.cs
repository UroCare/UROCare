using System;

namespace SHC.UROCare.UI
{
    public interface IOperationView : IView
    {
        /// <summary>
        /// Gets or set operation date value.
        /// </summary>
        DateTime OperationDate { get; set; }

        /// <summary>
        /// Gets or sets Anaesthesiologist value.
        /// </summary>
        int Anaesthesiologist { get; set; }

        /// <summary>
        /// Gets or sets Anaesthesia value.
        /// </summary>
        string Anaesthesia { get; set; }

        /// <summary>
        /// Get or set procedure value
        /// </summary>
        string Procedure { get; set; }

        /// <summary>
        /// Get or set details value.
        /// </summary>
        string Details { get; set; }

        /// <summary>
        /// Get or set Remarks value.
        /// </summary>
        string Remarks { get; set; }
    }    
}