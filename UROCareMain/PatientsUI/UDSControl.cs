using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class UDSControl : ChildControl, IUDSView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public UDSControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_udsPresenter = new UDSPresenter(this);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Process recommended colors to control.
        /// </summary>
        private void ProcessRecommendedColors()
        {
            RecommendedColors colors = UIFrameWorkClass.Instance.GetRecommendedColors();
            BackColor = colors.BackColor;

        }

        /// <summary>
        /// Initializes control.
        /// </summary>
        private void InitializeControl()
        {
            _complaintsTextBox.Focus();
        }
        #endregion
        
        #region Public properties

        /// <summary>
        /// Get set complaints value.
        /// </summary>
        public string Complaints 
        {
            get
            {
                return _complaintsTextBox.Text;
            }
            set
            {
                _complaintsTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get, Set Asociate Illness value.
        /// </summary>
        public string AssociateIllness 
        { 
            get
            {
                return _associatedIllnessTextBox.Text;
            }
            set
            {
                _associatedIllnessTextBox.Text = value;
            }
                
         }

        /// <summary>
        /// Get Set Anal tone value.
        /// </summary>
        public string AnalTone 
        { 
            get
            {
                return _analToneTextBox.Text;
            }
                
            set
            {
                _analToneTextBox.Text = value;
            }
         }

        /// <summary>
        /// Get Set BCR value
        /// </summary>
        public string BCR 
        { 
            get
            {
                return _bcrTextBox.Text;
            }
            set
            {
                _bcrTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set Exam other value.
        /// </summary>
        public string ExamOther
        {
            get
            {
                return _examOtherTextBox.Text;
            }
            set
            {
                _examOtherTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set Peak flow rate value
        /// </summary>
        public string PeakFlowRate 
        { 
            get
            {
                return _peakFlowRateTextBox.Text;
            }
            set
            {
                _peakFlowRateTextBox.Text = value;
            } 
        }

        /// <summary>
        /// Get Set voided volume.
        /// </summary>
        public string VoidedVolume 
        {
            get
            {
                return _voidedVolumeTextBox.Text;
            }
            set
            {
                _voidedVolumeTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set Residual volume
        /// </summary>
        public string ResidualVolume 
        {
            get
            {
                return _residualVolumeTextBox.Text;
            }
            set
            {
                _residualVolumeTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set uroflow remarks.
        /// </summary>
        public string UroflowRemarks 
        { 
            get
            {
                return _uroflowRemarksTextBox.Text;
            }
            set
            {
                _uroflowRemarksTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get set filling rate value.
        /// </summary>
        public string FillingRate 
        { 
            get
            {
                return _fillingRateTxtBox.Text;
            }
            set
            {
                _fillingRateTxtBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set Capacity.
        /// </summary>
        public string Capacity 
        { 
            get
            {
                return _capacityTextBox.Text;
            }
            set
            {
                _capacityTextBox.Text= value;
            }
        }

        /// <summary>
        /// Gget set Compliance
        /// </summary>
        public string Compliance 
        { 
            get
            {
                return _complianceTextBox.Text;
            }
            set
            {
                _complianceTextBox.Text= value;
            }
        }

        /// <summary>
        /// Get set stability
        /// </summary>
        public string Stability 
        { 
            get
            {
                return _stabilityTextBox.Text;
            }
            set
            {
                _stabilityTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set Sensation
        /// </summary>
        public string Sensation 
        { 
            get 
            {
                return _sensationTextBox.Text;
            }
            set 
            { 
                _sensationTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get set DLPP value
        /// </summary>
        public string DLPP 
        { 
            get
            {
                return _dlppTextBox.Text;
            }
            set
            { 
                _dlppTextBox.Text= value;
            }
        }

        /// <summary>
        /// Get set VLPP value
        /// </summary>
        public string VLPP 
        { 
            get
            {
                return _vlppTextBox.Text;
            }
            set
            {
                _vlppTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get set Stress inc value
        /// </summary>
        public string StressInc 
        { 
            get
            {
                return _stressIncTextBox.Text;
            }
            set 
            {
                _stressIncTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get set fill other value.
        /// </summary>
        public string FillOther
        { 
            get
            { 
                return _fillOtherTextBox.Text;
            }
            set 
            {
                _fillOtherTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set Fill Remarks value
        /// </summary>
        public string FillRemarks 
        { 
            get
            {
               return _fillRemarksTextBox.Text;
            }
            set
            {
                _fillRemarksTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set Detrusor Press value.
        /// </summary>
        public string DetrusorPress 
        { 
            get
            {
                return _detrusorPressureTextBox.Text;
            }
            set
            {
                _detrusorPressureTextBox.Text=value;
            }
        }
        
        /// <summary>
        /// Get Set void phase flow rate value.
        /// </summary>
        public string VoidPhaseFlowRate 
        { 
            get
            {
                return _voidingPhasePeakFlowRateTextBox.Text;
            }
            set
            {
                _voidingPhasePeakFlowRateTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set SPH Activity value
        /// </summary>
        public string SPHActivity 
        { 
            get
            {
                return _sphActivityTextBox.Text;
            }
            set
            {
                _sphActivityTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set resudal urine value
        /// </summary>
        public string ResudualUrine 
        { 
            get
            {
                return _residualUrineTextBox.Text;
            }
            set 
            {
                _residualUrineTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set void other value.
        /// </summary>
        public string VoidOther 
        { 
            get 
            {
                return _voidingPhaseOtherTextBox.Text;
            }
            set 
            {
                _voidingPhaseOtherTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set void remarks value
        /// </summary>
        public string VoidRemarks 
        { 
            get
            {
                return _voidingPhaseRemarks.Text;
            }
            set
            {
                _voidingPhaseRemarks.Text= value;
            }
        }

        /// <summary>
        /// Get Set conclusion value.
        /// </summary>
        public string Conclusion 
        { 
            get
            {
                return _conclusionTextBox.Text;
            }
            set
            {
                _conclusionTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set advise value.
        /// </summary>
        public string Advise 
        { 
            get
            {
                return _adviseTextBox.Text;
            }
            set
            {
                _adviseTextBox.Text= value;
            }
        }
        #endregion

        #region Child Control Implementation

        /// <summary>
        /// Populates patient information control
        /// </summary>
        /// <param name="guNo">GU No</param>
        /// <param name="guYear">GU Year</param>
        public override void PopulateControl(int guNo, int guYear)
        {

        }

        #endregion
    }
}