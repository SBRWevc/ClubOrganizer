using ClubOrganizer.Pages.Payment.Class;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.Payment
{
    public partial class Payment : Page
    {
        bool open = false;

        public Payment()
        {
            InitializeComponent();

            Animation();
            Update_data();
        }

        private async void Animation()
        {
            if (open == false)
            {
                open = true;

                await Task.Delay(800);

                ThicknessAnimation MGanimationSearch = new()
                {
                    From = new Thickness(108, 0, 0, -90),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                BottombarSearch.BeginAnimation(MarginProperty, MGanimationSearch);

                open = false;
            }
        }

        private void Update_data()
        {
            Payments.dt_payments = new();
            GetPayments.Get();
            DataPayment.ItemsSource = Payments.dt_payments.AsDataView();
        }

        private void ClientReset_Click(object sender, RoutedEventArgs e)
        {
            ClientList.Text = "";
            Update_data();
        }

        private void ClientSearch_Click(object sender, RoutedEventArgs e)
        {
            Payments.dt_payments = new();
            Payments.Client = ClientList.Text;
            GetClientPaymants.Get();
            DataPayment.ItemsSource = Payments.dt_payments.AsDataView();
        }

        private void ClientList_GotFocus(object sender, RoutedEventArgs e)
        {
            Payments.lt_clients = new();
            GetClientsList.Get();
            ClientList.ItemsSource = Payments.lt_clients.AsDataView();
            ClientList.DisplayMemberPath = "fullname";
            ClientList.SelectedValuePath = "id";
        }
    }
}
