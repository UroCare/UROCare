using System;
using System.Collections.Generic;
using System.Drawing;
using SHC.UROCare.UROCareBusinessObjects;

namespace SHC.UROCare.UI
{
    /// <summary>
    /// Represents patient header view contract.
    /// </summary>
    public interface IPatientInformationView : IView
    {
        /// <summary>
        /// Gets or sets patient name.
        /// </summary>
        string PatientName { get; set; }

        /// <summary>
        /// Gets or sets town name of patient
        /// </summary>
        string Town { get; set; }

        /// <summary>
        /// Gets or sets GUID of patient.
        /// </summary>
        string GUId { get; set; }

        /// <summary>
        /// Gets or sets patient image.
        /// </summary>
        Image PatientImage { get; set; }

        /// <summary>
        /// Gets or sets mobile number of patient.
        /// </summary>
        string Mobile { get; set; }

        /// <summary>
        /// Gets or sets Sex of the patient 
        /// </summary>
        SexEnum Sex { get; set; }

        /// <summary>
        /// Gets or sets Occupation of the patient.
        /// </summary>
        string Ocupation { get; set; }

        /// <summary>
        /// Gets or sets Registration date of the patient.
        /// </summary>
        string RegisterationDate { get; set; }

        /// <summary>
        /// Gets age years of the patient.
        /// </summary>
        int AgeYears { get; set; }

        /// <summary>
        /// Gets or sets AgeMonths of the patient.
        /// </summary>
        int AgeMonths { get; set; }

        /// <summary>
        /// Gets or sets Referal doctor.
        /// </summary>
        string ReferalDoctor { get; set; }

        /// <summary>
        /// Gets or sets AtPost of the patient.
        /// </summary>
        string AtPost { get; set; }

        /// <summary>
        /// Gets or sets District  of the patient.
        /// </summary>
        string District { get; set; }

        /// <summary>
        /// Gets or sets State of the patient.
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// Gets or sets Phone of the patient.
        /// </summary>
        string Phone { get; set; }

        string OPDDiagnosis { get; set; }
        /// <summary>
        /// Gets or sets Saluation of the patient.
        /// </summary>
        string Salutation { get; set; }

        List<SexEnum> SexCombo { set; }
    }
}