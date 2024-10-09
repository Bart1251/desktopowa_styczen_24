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

namespace desktopowa
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

        private void NumberLostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                Image1.Source = new BitmapImage(new Uri(Number.Text + "-zdjecie.jpg", UriKind.Relative));
                Image2.Source = new BitmapImage(new Uri(Number.Text + "-odcisk.jpg", UriKind.Relative));
            } catch 
            {
                Image1.Source = null;
                Image2.Source = null;
            }
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text.Length == 0 || LastName.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            MessageBox.Show(FirstName.Text + " " + LastName.Text + " kolor oczu " + Radios.Children.OfType<RadioButton>().Where(button => button.IsChecked == true).FirstOrDefault()!.Content);
        }
    }
}