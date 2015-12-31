using System;

namespace SHC.UROCare.UI
{
    public interface IAndrologyView : IView
    {
        /// <summary>
        /// Gets or set cheif complaints value.
        /// </summary>
        string CheifComplaints { get; set; }

        /// <summary>
        /// Gets or set any significant illness value.
        /// </summary>
        string AnySignificantIllness { get; set; }

        /// <summary>
        /// Gets or sets any treatment taken value.
        /// </summary>
        string AnyTreatmentTaken { get; set; }

        /// <summary>
        /// Gets or sets married since value
        /// 
        string MarriedSince { get; set; }

        /// <summary>
        /// Gets or sets alcoholism value.
        /// </summary>
        string Alcoholism { get; set; }

        /// <summary>
        /// Gets or sets smoking tobaco value.
        /// </summary>
        string SmokingTobaco { get; set; }

        /// <summary>
        /// Gets or sets fever value.
        /// </summary>
        string Fever { get; set; }

        /// <summary>
        /// Gets or sets mumps or orchitis value.
        /// </summary>
        string MumpsOrchitis { get; set; }

        /// <summary>
        /// Gets or sets ericition value.
        /// </summary>
        string Eriction { get; set; }

        /// <summary>
        /// Gets or sets ejavulation value.
        /// </summary>
        string Ejaculation { get; set; }

        /// <summary>
        /// Gets or sets general examination value.
        /// </summary>
        string GeneralExamination { get; set; }

        /// <summary>
        /// Get or set signs of virilization
        /// </summary>
        string SignsOfVirilization { get; set; }

        /// <summary>
        /// Get or Set PA value.
        /// </summary>
        string PA { get; set; }

        /// <summary>
        /// Get or Set PR value.
        /// </summary>
        string PR { get; set; }

        /// <summary>
        /// Get or set varicocele.
        /// </summary>
        string Varicocele { get; set; }

        /// <summary>
        /// Get or Set VAS value
        /// </summary>
        string VAS { get; set; }

        /// <summary>
        /// Get or set epididymis value.
        /// </summary>
        string Epididymis { get; set; }

        /// <summary>
        /// Get or Set Testis value.
        /// </summary>
        string Testis { get; set; }

        /// <summary>
        /// Get or set SR FSH value
        /// </summary>
        string SRFSH { get; set; }

        /// <summary>
        /// Get or set LH
        /// </summary>
        string LH { get; set; }

        /// <summary>
        /// Get or Set testosterone value.
        /// </summary>
        string Testosterone { get; set; }

        /// <summary>
        /// Get or set prolactin
        /// </summary>
        string Prolactin { get; set; }

        /// <summary>
        /// Get or set Semen Analysis value.
        /// </summary>
        string SemenAnalysis { get; set; }

        /// <summary>
        /// Get or set testicular biopsy value.
        /// </summary>
        string TesticularBiopsy { get; set; }

        /// <summary>
        /// Get or set treatment given value.
        /// </summary>
        string TreatmentGiven { get; set; }

        /// <summary>
        /// Get or set others value.
        /// </summary>
        string Others { get; set; }
    }    
}