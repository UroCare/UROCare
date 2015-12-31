using System;
using System.Collections.Generic;
using SHC.UROCare.UROCareBusinessObjects;
using SHC.UROCare.Utilities;

namespace SHC.UROCare.UI
{
    public class PatientNodePresenter
    {
        #region Private fields

        private readonly List<PatientContext> _contexts = new List<PatientContext>();
        private readonly IPatientNodeView _patientNodeView;
        private PatientObjectCollection _patientObjectCollection;
        
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor to create the instance of presenter.
        /// </summary>
        /// <param name="nodeView">Node view.</param>
        public PatientNodePresenter(IPatientNodeView nodeView) : this(nodeView, new PatientObjectCollection())
        {
        }

        /// <summary>
        /// Constructor to create the instance of presenter.
        /// </summary>
        /// <param name="nodeView">Node view.</param>
        /// <param name="patientObjectCollection">Collection</param>
        protected PatientNodePresenter(IPatientNodeView nodeView, PatientObjectCollection patientObjectCollection)
        {
            if (nodeView == null)
            {
                ExceptionManager.Throw(new ArgumentNullException("nodeView"));
            }
            _patientNodeView = nodeView;
            _patientObjectCollection = patientObjectCollection;
            _contexts = new List<PatientContext>();
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets view of the presenter
        /// </summary>
        public IPatientNodeView PatientNodeView
        {
            get
            {
                return _patientNodeView;
            }
        }

        /// <summary>
        /// Gets all the context of the node.
        /// </summary>
        public IList<PatientContext> Contexts
        {
            get
            {
                return _contexts;
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Get patients list
        /// </summary>
        /// <returns>List of Patient Business objects</returns>
        public PatientObjectCollection GetPatientList()
        {
            _patientObjectCollection.Clear();
            _patientObjectCollection.FillByRegistrationMonthYear(_patientNodeView.MonthCalendar.Month, _patientNodeView.MonthCalendar.Year);
            return _patientObjectCollection;
        }

        /// <summary>
        /// Initialize
        /// </summary>
        public void Initialize()
        {
            _patientNodeView.GUNumberSearch = _patientNodeView.GUNumber = string.Format("0000/{0}", DateTime.Today.Year);
        }

        #endregion
    }
}