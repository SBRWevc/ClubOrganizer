using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace ClubOrganizer.Pages.Mail
{
    public partial class Mail : Page
    {
        public Mail()
        {
            InitializeComponent();
            LoadPage();
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
