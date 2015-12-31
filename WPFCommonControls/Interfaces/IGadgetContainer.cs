// © 2012 - 2012 Sharma Health Care Pvt. Ltd.

namespace SHCPL
{
    /// <summary>
    /// Interface for all the gadget container controls.
    /// </summary>
    public interface IGadgetContainer
    {
        /// <summary>
        /// Get or sets snap region for the current gadget container.
        /// </summary>
        SnapRegions SnapRegion { get; set; }
    }
}