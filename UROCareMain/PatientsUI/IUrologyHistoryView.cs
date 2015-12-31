using System;
namespace SHC.UROCare.UI
{
    public interface IUrologyHistoryView : IView
    {
        /// <summary>
        /// Gets or set frequency value.
        /// </summary>
        string ChiefComplaints { get; set; }

        /// <summary>
        /// Gets or set frequency value.
        /// </summary>
        string Frequency { get; set; }

        /// <summary>
        /// Gets or sets hesitancy value.
        /// </summary>
        string Hesitancy { get; set; }

        /// <summary>
        /// Gets or sets nocturia.
        /// </summary>
        string Nocturia { get; set; }

        /// <summary>
        /// Gets or sets poor stream.
        /// </summary>
        string PoorStream { get; set; }

        /// <summary>
        /// Gets or sets urgency value.
        /// </summary>
        string Urgency { get; set; }

        /// <summary>
        /// Gets or sets intermittency value.
        /// </summary>
        string Intermittency { get; set; }

        /// <summary>
        /// Gets or sets dysuria value.
        /// </summary>
        string Dysuria { get; set; }

        /// <summary>
        /// Gets or sets straining.
        /// </summary>
        string Straining { get; set; }

        /// <summary>
        /// Gets or sets pyuria value.
        /// </summary>
        string Pyuria { get; set; }

        /// <summary>
        /// Gets or sets sesn of inc void value.
        /// </summary>
        string SenseOfIncVoid { get; set; }

        /// <summary>
        /// Gets or set lythuria value.
        /// </summary>
        string Lythuria { get; set; }

        /// <summary>
        /// Gets or sets terminal dibling.
        /// </summary>
        string TerminalDibling { get; set; }

        /// <summary>
        /// Gets or sets Chyluria value.
        /// </summary>
        string Chyluria { get; set; }

        /// <summary>
        /// Gets or sets urge incontinence value.
        /// </summary>
        string UrgeIncontinence { get; set; }

        /// <summary>
        /// Gets or sets Fever value.
        /// </summary>
        string Fever { get; set; }

        /// <summary>
        /// Gets or sets stress incontinences value.
        /// </summary>
        string StressIncontinence { get; set; }

        /// <summary>
        /// Gets or sets IPSS value.
        /// </summary>
        string IPSS { get; set; }

        /// <summary>
        /// Gets or set bpi value.
        /// </summary>
        string BPI { get; set; }

        /// <summary>
        /// Gets or sets pain value.
        /// </summary>
        string Pain { get; set; }

        /// <summary>
        /// Gets or sets hematuria value.
        /// </summary>
        string Hematuria { get; set; }

        /// <summary>
        /// Gets or sets others value.
        /// </summary>
        string Others { get; set; }

        /// <summary>
        /// Gets or sets medication value.
        /// </summary>
        string Medication { get; set; }

        /// <summary>
        /// Gets or sets personal value.
        /// </summary>
        string Personal { get; set; }

        /// <summary>
        /// Gets or sets Surgery value.
        /// </summary>
        string Surgery { get; set; }

        /// <summary>
        /// Gets or sets MH value.
        /// </summary>
        string MH { get; set; }

        /// <summary>
        /// Gets or sets allergies value.
        /// </summary>
        string Allergies { get; set; }

        /// <summary>
        /// Gets or sets allergies value.
        /// </summary>
        string OBGY { get; set; }

        /// <summary>
        /// Gets or sets past text value.
        /// </summary>
        string Past { get; set; }

        /// <summary>
        /// Gets or sets family value.
        /// </summary>
        string Family { get; set; }
    }
}