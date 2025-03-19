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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        string input = tbxVikt.Text;

        if (int.TryParse(input, out int vikt))
        {
            switch (vikt)
            {
                case <= 0:
                    lblResultat.Content = "Ogiltig vikt, (1-2000)";
                    break;
                case <= 50:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 22 kr (1 frimärken)";
                    break;
                case <= 100:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 44 kr (2 frimärken)";
                    break;
                case <= 250:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 66 kr (3 frimärken)";
                    break;
                case <= 500:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 88 kr (4 frimärken)";
                    break;
                case <= 1000:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 132 kr (6 frimärken)";
                    break;
                case <= 2000:
                    lblResultat.Content = $"Brev som väger {vikt}g kostar 154 kr (7 frimärken)";
                    break;
                default:
                    lblResultat.Content = "Ogiltig vikt, ange en vikt (1-2000)";
                    break;
            }
        }
        else
        {
            lblResultat.Content = "Ogiltig vikt, ange en vikt (1-2000)";
        }
    }
}



