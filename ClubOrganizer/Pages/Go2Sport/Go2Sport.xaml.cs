using System.Windows.Controls;
using System.Windows;
using System.Threading.Tasks;

namespace ClubOrganizer.Pages.Go2Sport
{
    public partial class Go2Sport : Page
    {
        public Go2Sport()
        {
            InitializeComponent();
            LoadPage();
        }

        private void Page_Unloaded(object sender, System.Windows.RoutedEventArgs e)
        {
            webView.Stop();
        }

        private async void LoadPage()
        {
            Progress.Visibility = Visibility.Visible;
            webView.Visibility = Visibility.Collapsed;

            await Task.Delay(1800);

            Progress.Visibility = Visibility.Collapsed;
            webView.Visibility = Visibility.Visible;
        }
    }
}
