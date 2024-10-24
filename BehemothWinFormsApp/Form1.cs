using BehemothWinFormsApp.Class;

namespace BehemothWinFormsApp
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
            viewControl1.SetParty(0);
            viewControl2.SetParty(1);
            viewControl3.SetParty(2);
            viewControl4.SetParty(3);
        }
    }
}
