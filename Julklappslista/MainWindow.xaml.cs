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

namespace Julklappslista;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    // Våra variabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Lås gränssnittet
        stpInmattning.IsEnabled = false;
        stpListan.IsEnabled = false;

    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // Läs av ruta
        string antal = txbAntal.Text;

        // Första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Du måste ange ett antal julklappar!";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                // Koppla List till ListBox
                lsbJulklappar.ItemsSource = listaJulklappar;

                // Lås upp gränssnittet
                stpMax.IsEnabled = false;
                stpInmattning.IsEnabled = true;
                stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "Du måste ange ett heltal!";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        // Läs av text rutorna
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        if (julklapp == "" || mottagare == "")
        {
            txbStatus.Text = "Du måste ange både julklapp och mottagare!";
            return;
        }
        else
        {
        listaJulklappar.Add($"{julklapp} till {mottagare}");
        lsbJulklappar.Items.Refresh();
        }

       
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }
}