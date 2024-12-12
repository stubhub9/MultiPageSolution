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

namespace PageNav
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

        private void Button_Click_Page1 ( object sender, RoutedEventArgs e )
        {
            MainFrame.Content = new RefPages.GradientSpreadMethods ();
        }

        private void Button_Click_Page2 ( object sender, RoutedEventArgs e )
        {
            MainFrame.Content = new MinXamlPages.RadialGradientPage ();
        }

        private void Button_Click_Page3 ( object sender, RoutedEventArgs e )
        {
            MainFrame.Content = new MinXamlPages.RadialGradientPage ();
        }



        private void Button_Click_Page4 ( object sender, RoutedEventArgs e )
        {
            MainFrame.Content = new MinXamlPages.RadialGradientPage ();
        }

    }
}