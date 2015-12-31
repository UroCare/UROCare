using System.Windows.Forms;
using SHC.UROCare.UIFramework;

namespace SHC.UROCare.UI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            ProcessRecommendedColors();
            InitializeControl();
        }

        private void ProcessRecommendedColors()
        {
            RecommendedColors colors = UIFrameWorkClass.Instance.GetRecommendedColors();
            BackColor = colors.BackColor;
            _iconPictureBox.BackColor = BackColor;         
        }

        private void InitializeControl()
        {
            
        }
    }
}