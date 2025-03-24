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
        InitializeComponent(tbxTal1, );
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(tbxTal1.Text, out double Tal1) && double.TryParse(tbxTal2.Text, out double Tal2))
        {
            lblResultat.Content = FunctionBeräkna(Tal1, Tal2);
        }
        else
        {
            lblResultat.Content = $"Du har inmatat ett ogiltigt värde!";
        }
    }

    ///////////////////////////////////////////

    /// <summary>
    /// funktion som utför beräkningarna
    /// </summary>
    /// <param name="Tal1"></param>
    /// <param name="Tal2"></param>
    /// <returns></returns> <summary>
    /// 
    /// </summary>
    /// <param name="Tal1"></param>
    /// <param name="Tal2"></param>
    /// <returns></returns>
    public string FunctionBeräkna(double Tal1, double Tal2)
    {

        switch (tbxOperator.Text)
        {
            case "+":
                return $"{Tal1} + {Tal2} = {Tal1 + Tal2}";
            case "-":
                return $"{Tal1} - {Tal2} = {Tal1 - Tal2}";
            case "*":
                return $"{Tal1} * {Tal2} = {Math.Round(Tal1 * Tal2, 2)}";
            case "/":
                if (Tal2 != 0)
                {
                    return $"{Tal1} / {Tal2} = {Math.Round(Tal1 / Tal2, 2)}";
                }
                else
                {
                    return $"Det är olagligt att dividera ett tal med 0";
                }
            default:
                return $"Ogiltig operator";
        }
    }
}