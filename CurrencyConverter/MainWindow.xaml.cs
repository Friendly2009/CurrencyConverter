using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AboutProgramBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            AboutProgramBtn.Style = (Style)FindResource("MouseOverButtonStyle");
        }

        private void AboutProgramBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            AboutProgramBtn.Style = (Style)FindResource("NoMouseOverButtonStyle");
        }

        private void HelpBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            HelpBtn.Style = (Style)FindResource("MouseOverButtonStyle");
        }

        private void HelpBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            HelpBtn.Style = (Style)FindResource("NoMouseOverButtonStyle");
        }

        private void ExitBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            ExitBtn.Style = (Style)FindResource("MouseOverButtonStyle");
        }
        
        private void ExitBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            ExitBtn.Style = (Style)FindResource("NoMouseOverButtonStyle");
        }
    }
}