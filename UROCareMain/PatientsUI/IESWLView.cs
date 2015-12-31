using System;

namespace SHC.UROCare.UI
{
    public interface IESWLView : IView
    {
        /// <summary>
        /// Gets or set ESWL date value.
        /// </summary>
        DateTime ESWLDate { get; set; }

        /// <summary>
        /// Gets or set ESWL Size value.
        /// </summary>
        string ESWLSize { get; set; }

        /// <summary>
        /// Gets or sets Side value.
        /// </summary>
        string Side { get; set; }

        /// <summary>
        /// Gets or sets Site.
        /// </summary>
        string ESWLSite { get; set; }

        /// <summary>
        /// Gets or sets Shock Waves.
        /// </summary>
        string SockWaves { get; set; }

        /// <summary>
        /// Gets or sets ESWL level.
        /// </summary>
        string ESWLLevel { get; set; }

        /// <summary>
        /// Gets or sets Fluroscopy value.
        /// </summary>
        string Fluroscopy { get; set; }

        /// <summary>
        /// Gets or sets Analgesic value.
        /// </summary>
        string Analgesic { get; set; }

        /// <summary>
        /// Gets or sets IV Fluids.
        /// </summary>
        string IVFluids { get; set; }

        /// <summary>
        /// Gets or sets Complications value.
        /// </summary>
        string Complications { get; set; }

        /// <summary>
        /// Gets or sets Comments value.
        /// </summary>
        string Comments { get; set; }
    }    
}