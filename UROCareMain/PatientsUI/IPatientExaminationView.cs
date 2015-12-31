using System;
namespace SHC.UROCare.UI
{
    public interface IPatientExaminationView : IView
    {
        /// <summary>
        /// Gets or sets general examination value.
        /// </summary>
        string GeneralExamination { get; set; }

        /// <summary>
        /// Gets or sets Pulse per minute
        /// </summary>
        int Pulse { get; set; }

        /// <summary>
        /// Gets or sets blood pressure value.
        /// </summary>
        string BloodPressure { get; set; }

        /// <summary>
        /// Gets or sets weight vlaue.
        /// </summary>
        string Weight { get; set; }

        /// <summary>
        /// Gets or sets abdomen value.
        /// </summary>
        string Abdomen { get; set; }

        /// <summary>
        /// Gets or sets Genitalia value.
        /// </summary>
        string Genitalia { get; set; }

        /// <summary>
        /// Gets or sets Anal tone.
        /// </summary>
        string AnalTone { get; set; }

        /// <summary>
        /// Gets or sets BCR.
        /// </summary>
        string BCR { get; set; }

        /// <summary>
        /// Gets or sets Prostate.
        /// </summary>
        string Prostate { get; set; }

        /// <summary>
        /// Gets or sets others.
        /// </summary>
        string PROthers { get; set; }

        /// <summary>
        /// Gets or sets PS.
        /// </summary>
        string PS { get; set; }

        /// <summary>
        /// Gets or sets PV.
        /// </summary>
        string PV { get; set; }

        /// <summary>
        /// Gets or set CNS.
        /// </summary>
        string CNS { get; set; }

        /// <summary>
        /// Gets or sets CVS.
        /// </summary>
        string CVS { get; set; }

        /// <summary>
        /// Gets or sets RS.
        /// </summary>
        string RS { get; set; }

        /// <summary>
        /// Gets or sets Remarks.
        /// </summary>
        string Remarks { get; set; }

        /// <summary>
        /// Gets or sets others examination.
        /// </summary>
        string OthersExamination { get; set; }

        ///// <summary>
        ///// Gets or sets created by value.
        ///// </summary>
        //string CreatedBy { get; set; }

        ///// <summary>
        ///// Gets or sets created date value.
        ///// </summary>
        //DateTime CreatedDate { get; set; }

        ///// <summary>
        ///// Gets or sets modified by value.
        ///// </summary>
        //string ModifiedBy { get; set; }

        ///// <summary>
        ///// Gets or sets modified date value.
        ///// </summary>
        //DateTime ModifiedDate { get; set; }
    }
}