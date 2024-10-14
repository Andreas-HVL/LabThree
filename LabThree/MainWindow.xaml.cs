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

namespace LabThree
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
        
        private void GoToPage1_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Page1
            MainFrame.NavigationService.Navigate(new Boka());
            MessageBox.Show("Hej, Boka");
        }
        private void GoToPage2_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Page2
            MainFrame.NavigationService.Navigate(new Avboka());
            MessageBox.Show("Hej, Avboka");
        }
        
    }
}