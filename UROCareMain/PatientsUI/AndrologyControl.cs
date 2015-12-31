using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class AndrologyControl : ChildControl, IAndrologyView
    {
        #region Private fields

        private UrologyHistoryPresenter _urologyHistoryPresenter;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to create the instance of control. 
        /// </summary>
        public AndrologyControl()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();
            //_urologyHistoryPresenter = new UrologyHistoryPresenter(this);
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
            _chiefComplaint.Focus();           
        }
        #endregion

        #region Public properties

       
        #endregion

        public string CheifComplaints
        {
            get
            {
                return _chiefComplaint.Text;
            }
            set
            {
                _chiefComplaint.Text = value;
            }
        }

        public string AnySignificantIllness
        {
            get
            {
                return _anySignificantIllness.Text;
            }
            set
            {
                _anySignificantIllness.Text = value;
            }
        }

        public string AnyTreatmentTaken
        {
            get
            {
                return _anyTreatmentTaken.Text;
            }
            set
            {
                _anyTreatmentTaken.Text = value;
            }
        }

        public string MarriedSince
        {
            get
            {
                return _marriedSince.Text;
            }
            set
            {
                _marriedSince.Text = value;
            }
        }

        public string Alcoholism
        {
            get
            {
                return _alcoholism.Text;
            }
            set
            {
                _alcoholism.Text = value;
            }
        }

        public string SmokingTobaco
        {
            get
            {
                return _smoklingTobaco.Text;
            }
            set
            {
                _smoklingTobaco.Text = value;
            }
        }

        public string Fever
        {
            get
            {
                return _fever.Text;
            }
            set
            {
                _fever.Text = value;
            }
        }

        public string MumpsOrchitis
        {
            get
            {
                return _mumpsOrchitis.Text;
            }
            set
            {
                _mumpsOrchitis.Text = value;
            }
        }

        public string Eriction
        {
            get
            {
                return _eriction.Text;
            }
            set
            {
                _eriction.Text = value;
            }
        }

        public string Ejaculation
        {
            get
            {
                return _ejaculation.Text;
            }
            set
            {
                _ejaculation.Text = value;
            }
        }

        public string GeneralExamination
        {
            get
            {
                return _generalExamination.Text;
            }
            set
            {
                _generalExamination.Text = value;
            }
        }

        public string SignsOfVirilization
        {
            get
            {
                return _signsOfVirilization.Text;
            }
            set
            {
                _signsOfVirilization.Text = value;
            }
        }

        public string PA
        {
            get
            {
                return _pa.Text;
            }
            set
            {
                _pa.Text = value;
            }
        }

        public string PR
        {
            get
            {
                return _pr.Text;
            }
            set
            {
                _pr.Text = value;
            }
        }

        public string Varicocele
        {
            get
            {
                return _varicocele.Text;
            }
            set
            {
                _varicocele.Text = value;
            }
        }

        public string VAS
        {
            get
            {
                return _vas.Text;
            }
            set
            {
                _vas.Text = value;
            }
        }

        public string Epididymis
        {
            get
            {
                return _epididymis.Text;
            }
            set
            {
                _epididymis.Text = value;
            }
        }

        public string Testis
        {
            get
            {
                return _testis.Text;
            }
            set
            {
                _testis.Text = value;
            }
        }

        public string SRFSH
        {
            get
            {
                return _srFSH.Text;
            }
            set
            {
                _srFSH.Text = value;
            }
        }

        public string LH
        {
            get
            {
                return _lh.Text;
            }
            set
            {
                _lh.Text = value;
            }
        }

        public string Testosterone
        {
            get
            {
                return _testosterone.Text;
            }
            set
            {
                _testosterone.Text = value;
            }
        }

        public string Prolactin
        {
            get
            {
                return _prolactin.Text;
            }
            set
            {
                _prolactin.Text = value;
            }
        }

        public string SemenAnalysis
        {
            get
            {
                return _semenAnalysis.Text;
            }
            set
            {
                _semenAnalysis.Text = value;
            }
        }

        public string TesticularBiopsy
        {
            get
            {
                return _testicularBiopsy.Text;
            }
            set
            {
                _testicularBiopsy.Text = value;
            }
        }

        public string TreatmentGiven
        {
            get
            {
                return _treatmentGiven.Text;
            }
            set
            {
                _treatmentGiven.Text = value;
            }
        }

        public string Others
        {
            get
            {
                return _othersTextBox.Text;
            }
            set
            {
                _othersTextBox.Text = value;
            }
        }

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