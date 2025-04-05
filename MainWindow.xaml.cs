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

namespace BuisnessTransactionsManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SearchPage s1 = new SearchPage();
        public NewItemPage n1 = new NewItemPage();
        public ModifyPage m1 = new ModifyPage();
        public Home home = new Home();
        
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = home;
        }

        private void miSearchClick(object sender, RoutedEventArgs e)
        {
            Main.Content = s1;
            
        }

        private void miNewClick(object sender, RoutedEventArgs e)
        {
            Main.Content = n1;
        }

        private void miModifyPageClick(object sender, RoutedEventArgs e)
        {
            Main.Content = m1;
        }

        private void miHomeClick(object sender, RoutedEventArgs e)
        {
            Main.Content = home;
        }
    }
}