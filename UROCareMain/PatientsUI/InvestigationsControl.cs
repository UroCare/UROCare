using System;
using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class InvestigationControl : ChildControl, IInvestigations
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public InvestigationControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();

            //_investigationPresenter = new InvestigationPresenter(this);
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
            _hbTextBox.Focus();
        }
        #endregion
        
        #region Public properties
           
        /// <summary>
        /// Get and Set HB.
        /// </summary>
        public string HB
        {
            get
            {
                return _hbTextBox.Text;
            }
            set
            {
                _hbTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set TC
        /// </summary>
        public string TC
        {
            get
            {
                return _tcTextBox.Text;
            }
            set
            {
                _tcTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set DC
        /// </summary>
        public string DC
        {
            get
            {
                return _dcTextBox.Text;
            }
            set
            {
                _dcTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set SR Creat
        /// </summary>
        public string SRCreat
        {
            get
            {
                return _srCreatTextBox.Text;
            }
            set
            {
                _srCreatTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set BUL
        /// </summary>
        public string BUL
        {
            get
            {
                return _bulTextBox.Text;
            }
            set
            {
                _bulTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set SR Uric acid
        /// </summary>
        public string SRUricAcid
        {
            get
            {
                return _srUricAcidTextBox.Text;
            }
            set
            {
                _srUricAcidTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set SR CA+2
        /// </summary>
        public string SRCAPlus2
        {
            get
            {
                return _srCA2TextBox.Text;
            }
            set
            {
                _srCA2TextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set SR NA+
        /// </summary>
        public string SRNAPlus
        {
            get
            {
                return _srNAPlusTextBox.Text;
            }
            set
            {
                _srNAPlusTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get Set SR K Plus
        /// </summary>
        public string SRKPlus
        {
            get
            {
                return _srKPlusTextBox.Text;
            }
            set
            {
                _srKPlusTextBox.Text= value;
            }
        }

        /// <summary>
        /// Get and Set ESR
        /// </summary>
        public string ESR
        {
            get
            {
                return _esrTextBox.Text;
            }
            set
            {
                _esrTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set Urine
        /// </summary>
        public string Urine
        {
            get
            {
               return _urineTextBox.Text;
            }
            set
            {
                _urineTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set BSL
        /// </summary>
        public string BSL
        {
            get
            {
                return _bslTextBox.Text;
            }
            set
            {
                _bslTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set SR PSA
        /// </summary>
        public string SRPSA
        {
            get
            {
                return _srPSATextBox.Text;
            }
            set
            {
                _srPSATextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set HIV
        /// </summary>
        public string HIV
        {
            get
            {
                return _hivTextBox.Text;
            }
            set
            {
                _hivTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set HBS Ag
        /// </summary>
        public string HBSAG
        {
            get
            {
                return _hbsAgTextBox.Text;
            }
            set
            {
                _hbsAgTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set Urine Chyle
        /// </summary>
        public string UrineChyle
        {
            get
            {
                return _urineChyleTextBox.Text;
            }
            set
            {
                _urineChyleTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set USG
        /// </summary>
        public string USG
        {
            get
            {
                return _usgTextBox.Text;
            }
            set
            {
                _usgTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set KUB
        /// </summary>
        public string KUB
        {
            get
            {
                return _kubTextBox.Text;
            }
            set
            {
                _kubTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set IVP
        /// </summary>
        public string IVP
        {
            get
            {
                return _ivpTextBox.Text;
            }
            set
            {
                _ivpTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set NCHCT
        /// </summary>
        public string NCHCT
        {
            get
            {
                return _nchctTextBox.Text;
            }
            set
            {
                _nchctTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set MCU
        /// </summary>
        public string MCU
        {
            get
            {
                return _mcuTextBox.Text;
            }
            set
            {
                _mcuTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set RGU
        /// </summary>
        public string RGU
        {
            get
            {
                return _rguTextBox.Text;
            }
            set
            {
                _rguTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set CT Scan
        /// </summary>
        public string CTScan
        {
            get
            {
                return _ctScanTextBox.Text;
            }
            set
            {
                _ctScanTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set Renogram
        /// </summary>
        public string Renogram
        {
            get
            {
                return _renogramTextBox.Text;
            }
            set
            {
                _renogramTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and set TRUS
        /// </summary>
        public string TRUS
        {
            get
            {
                return _trusTextBox.Text;
            }
            set
            {
                _trusTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set Urine CS
        /// </summary>
        public string UrineCS
        {
            get
            {
                return _urineCSTextBox.Text;
            }
            set
            {
                _urineCSTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and set IgM
        /// </summary>
        public string IgM
        {
            get
            {
                return _igmTextBox.Text; ;
            }
            set
            {
                _igmTextBox.Text=value;
            }
        }

        /// <summary>
        /// Ge and Set IgA
        /// </summary>
        public string IgA
        {
            get
            {
                return _igaTextBox.Text;
            }
            set
            {
                _igaTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set IgG
        /// </summary>
        public string IgG
        {
            get
            {
                return _iggTextBox.Text; ;
            }
            set
            {
                _iggTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Urine for AFB
        /// </summary>
        public string UrineForAFB
        {
            get
            {
                return _urineForAFBTextBox.Text;
            }
            set
            {
                _urineForAFBTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set BACTEC
        /// </summary>
        public string BACTEC
        {
            get
            {
                return _bactecTextBox.Text;
            }
            set
            {
                _bactecTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set PCR
        /// </summary>
        public string PCR
        {
            get
            {
                return _pcrTextBox.Text;
            }
            set
            {
                _pcrTextBox.Text=value;
            }
        }
        
        /// <summary>
        /// Get and Set MRI
        /// </summary>
        public string MRI
        {
            get
            {
                return _mriTextBox.Text;
            }
            set
            {
                _mriTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Bone Scan
        /// </summary>
        public string BoneScan
        {
            get
            {
                return _boneScanTextBox.Text;
            }
            set
            {
                _boneScanTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Stone Analysis
        /// </summary>
        public string StoneAnalysis
        {
            get
            {
                return _stoneAnalysisTextBox.Text;
            }
            set
            {
                _stoneAnalysisTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Other
        /// </summary>
        public string Other
        {
            get
            {
                return _otherTextBox.Text;
            }
            set
            {
                _otherTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Volume
        /// </summary>
        public string Volume
        {
            get
            {
                return _volumeTextBox.Text;
            }
            set
            {
                _volumeTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set PH
        /// </summary>
        public string PH
        {
            get
            {
                return _phTextBox.Text;
            }
            set
            {
                _phTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get Set Calcium
        /// </summary>
        public string Calcium
        {
            get
            {
                return _calciumTextBox.Text; ;
            }
            set
            {
                _calciumTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Uric Acid
        /// </summary>
        public string UricAcid
        {
            get
            {
                return _uricAcidTextBox.Text;
            }
            set
            {
                _uricAcidTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Sodium
        /// </summary>
        public string Sodium
        {
            get
            {
                return _sodiumTextBox.Text;
            }
            set
            {
                _sodiumTextBox.Text =value;
            }
        }

        /// <summary>
        /// Get and Set OXalate
        /// </summary>
        public string Oxalate
        {
            get
            {
                return _oxalateTextBox.Text;
            }
            set
            {
                _oxalateTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Citrate
        /// </summary>
        public string Citrate
        {
            get
            {
                return _citrateTextBox.Text;
            }
            set
            {
                _citrateTextBox.Text=value;
            }
        }

        /// <summary>
        /// Get and Set Sulfate
        /// </summary>
        public string Sulfate
        {
            get
            {
                return _sulfateTextBox.Text;
            }
            set
            {
                _sulfateTextBox.Text = value;
            }
        }

        /// <summary>
        /// Get and Set Phosphorous
        /// </summary>
        public string Phosphorous
        {
            get
            {
                return _phosphorousTextBox.Text;
            }
            set
            {
                _phosphorousTextBox.Text=value;
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