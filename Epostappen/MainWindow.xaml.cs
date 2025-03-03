using System.Windows;
using System.Net.Mail;
using System.Net;


namespace Epostappen;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        // Läs av epost & meddelanden
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        // Sanity check
        if (epost != "" && meddelande != "")
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("", "");
            smtp.Send();

        }
        else
        {
           lblStatus.Content = "UHUHUH"; 
        }
    }
}