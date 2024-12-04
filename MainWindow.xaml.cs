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

namespace WPFCheckBox
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

        private void cbAlleZutaten_Checked(object sender, RoutedEventArgs e)
        {
            bool neueAuswahl = (cbAlleZutaten.IsChecked == true);
            cbSalami.IsChecked = neueAuswahl;
            cbSchinken.IsChecked = neueAuswahl;
            cbMozarella.IsChecked = neueAuswahl;
            cbThunfisch.IsChecked = neueAuswahl;
            cbTomaten.IsChecked = neueAuswahl;
            cbCremeFreche.IsChecked = neueAuswahl;
            cbChampingnons.IsChecked = neueAuswahl;
        }

        private void cbCheckÄnderung(object sender, RoutedEventArgs e)
        {
            cbAlleZutaten.IsChecked = null;
            // wenn alle zutaen ausgewählt sind
            if ((cbSalami.IsChecked == true) 
                && (cbSchinken.IsChecked == true) 
                && (cbMozarella.IsChecked == true) 
                && (cbThunfisch.IsChecked == true)
                && (cbTomaten.IsChecked == true)
                && (cbCremeFreche.IsChecked == true)
                && (cbChampingnons.IsChecked == true))
            {
                cbAlleZutaten.IsChecked = true;
            }
            // wenn keine zutaten ausgewählt sind
            if ((cbSalami.IsChecked == false)
                && (cbSchinken.IsChecked == false)
                && (cbMozarella.IsChecked == false)
                && (cbThunfisch.IsChecked == false)
                && (cbTomaten.IsChecked == false)
                && (cbCremeFreche.IsChecked == false)
                && (cbChampingnons.IsChecked == false))
            {
                cbAlleZutaten.IsChecked = false;
            }
        }
    }
}