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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(tbxTal1.Text, out double Tal1) && double.TryParse(tbxTal2.Text, out double Tal2))
        {
            switch (tbxOperator.Text)
            {
                case "+":
                    lblResultat.Content = $"{Tal1} + {Tal2} = {Tal1 + Tal2}";
                    break;
                case "-":
                    lblResultat.Content = $"{Tal1} - {Tal2} = {Tal1 - Tal2}";
                    break;
                case "*":
                    lblResultat.Content = $"{Tal1} * {Tal2} = {Math.Round(Tal1 * Tal2, 2)}";
                    break;
                case "/":
                    if (Tal2 != 0)
                    {
                        lblResultat.Content = $"{Tal1} / {Tal2} = {Math.Round(Tal1 / Tal2, 2)}";
                    }
                    else
                    {
                        lblResultat.Content = $"Det är olagligt att dividera ett tal med 0";
                    }
                    break;
                default:
                    lblResultat.Content = $"Ogiltig operator";
                    break;
            }
        }
        else
        {
            lblResultat.Content = $"Du har inmatat ett ogiltigt värde!";
        }
    }
}