using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHC.UROCare.UI
{
    public interface IUDSView : IView
    {
        /// <summary>
        /// Get set complaints value.
        /// </summary>
        string Complaints { get; set; }

        /// <summary>
        /// Get, Set Asociate Illness value.
        /// </summary>
        string AssociateIllness { get; set; }

        /// <summary>
        /// Get Set Anal tone value.
        /// </summary>
        string AnalTone { get; set; }

        /// <summary>
        /// Get Set BCR value
        /// </summary>
        string BCR { get; set; }

        /// <summary>
        /// Get Set Exam other value.
        /// </summary>
        string ExamOther { get; set; }

        /// <summary>
        /// Get Set Peak flow rate value
        /// </summary>
        string PeakFlowRate { get; set; }

        /// <summary>
        /// Get Set voided volume.
        /// </summary>
        string VoidedVolume { get; set; }

        /// <summary>
        /// Get Set Residual volume
        /// </summary>
        string ResidualVolume { get; set; }

        /// <summary>
        /// Get Set uroflow remarks.
        /// </summary>
        string UroflowRemarks { get; set; }

        /// <summary>
        /// Get set filling rate value.
        /// </summary>
        string FillingRate { get; set; }

        /// <summary>
        /// Get Set Capacity.
        /// </summary>
        string Capacity { get; set; }

        /// <summary>
        /// Gget set Compliance
        /// </summary>
        string Compliance { get; set; }
        
        /// <summary>
        /// Get set stability
        /// </summary>
        string Stability { get; set; }

        /// <summary>
        /// Get Set Sensation
        /// </summary>
        string Sensation { get; set; }

        /// <summary>
        /// Get set DLPP value
        /// </summary>
        string DLPP { get; set; }

        /// <summary>
        /// Get set VLPP value
        /// </summary>
        string VLPP { get; set; }

        /// <summary>
        /// Get set Stress inc value
        /// </summary>
        string StressInc { get; set; }

        /// <summary>
        /// Get set fill other value.
        /// </summary>
        string FillOther { get; set; }

        /// <summary>
        /// Get Set Fill Remarks value
        /// </summary>
        string FillRemarks { get; set; }

        /// <summary>
        /// Get Set Detrusor Press value.
        /// </summary>
        string DetrusorPress { get; set; }

        /// <summary>
        /// Get Set void phase flow rate value.
        /// </summary>
        string VoidPhaseFlowRate { get; set; }

        /// <summary>
        /// Get Set SPH Activity value
        /// </summary>
        string SPHActivity { get; set; }

        /// <summary>
        /// Get Set resudal urine value
        /// </summary>
        string ResudualUrine { get; set; }

        /// <summary>
        /// Get Set void other value.
        /// </summary>
        string VoidOther { get; set; }

        /// <summary>
        /// Get Set void remarks value
        /// </summary>
        string VoidRemarks { get; set; }

        /// <summary>
        /// Get Set conclusion value.
        /// </summary>
        string Conclusion { get; set; }

        /// <summary>
        /// Get Set advise value.
        /// </summary>
        string Advise { get; set; }
    }
}
