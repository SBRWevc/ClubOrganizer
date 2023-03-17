using ClubOrganizer.Pages.Fast_Tennis.Class;
using ClubOrganizer.Pages.List_services.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.List_services
{
    public partial class List_services : Page
    {
        bool Process = false;

        public List_services()
        {
            InitializeComponent();

            Animation();
        }

        private async void Animation()
        {
            if (Process != true)
            {
                Process = true;

                await Task.Delay(800);
                ThicknessAnimation MGanimation = new()
                {
                    From = new Thickness(635, 0, 0, -90),
                    To = new Thickness(635, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);

                ThicknessAnimation MGanimationSearch = new()
                {
                    From = new Thickness(-55, 0, 0, -90),
                    To = new Thickness(-55, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                BottombarSearch.BeginAnimation(MarginProperty, MGanimationSearch);

                Process = false;
            }
        }

        private void ClientList_GotFocus(object sender, RoutedEventArgs e)
        {
            ClientsData.lt_clients = new();
            GetClientsList.Get();
            ClientList.ItemsSource = ClientsData.lt_clients.AsDataView();
            ClientList.DisplayMemberPath = "fullname";
            ClientList.SelectedValuePath = "id";
        }

        private async void ClientSearch_Click(object sender, RoutedEventArgs e)
        {
            if (ClientList.Text != "")
            {
                Services.dt_services = new DataTable();
                ClientsData.fullname = ClientList.Text;
                GetContract.Get();
                DataServices.ItemsSource = Services.dt_services.AsDataView();

                if (Process != true)
                {
                    Process = true;

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                    Icon.Foreground = Brushes.Coral;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(635, 0, 0, 30),
                        To = new Thickness(635, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(635, 0, 0, -90),
                        To = new Thickness(635, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(635, 0, 0, -90),
                        To = new Thickness(635, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(635, 0, 0, 30),
                        To = new Thickness(635, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                    Process = false;
                }
            }
        }

        private async void ClientReset_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                ClientList.Text = "";

                Services.dt_services = new DataTable();
                DataServices.ItemsSource = Services.dt_services.AsDataView();

                Services.dt_days = new DataTable();
                DataDays.ItemsSource = Services.dt_days.AsDataView();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
                Icon.Foreground = Brushes.Black;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(635, 0, 0, 30),
                    To = new Thickness(635, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(635, 0, 0, -90),
                    To = new Thickness(635, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(635, 0, 0, -90),
                    To = new Thickness(635, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(635, 0, 0, 30),
                    To = new Thickness(635, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            if (DataServices.SelectedItem == null)
            {
                return;
            }
            else
            {
                string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string path = doc + @"\Ладога\Docx\Счета\Temp";

                DirectoryInfo dirInfo = new(path);
                if (dirInfo.Exists) 
                {
                    Directory.Delete(path, true);
                }

                DataRowView rowView = (DataRowView)DataServices.SelectedItem;
                Services.id_ser = Convert.ToInt32(rowView["ID"]);

                Docx.Create();
                DayData.Get();
                Docx.Footer();

                Services.dt_days = new DataTable();
                GetDays.Get();
                DataDays.ItemsSource = Services.dt_days.AsDataView();

                Services.dt_services = new DataTable();
                ClientsData.fullname = ClientList.Text;
                GetContract.Get();
                DataServices.ItemsSource = Services.dt_services.AsDataView();
            }
        }

        private void Choice_Click(object sender, RoutedEventArgs e)
        {
            if (DataServices.SelectedItem == null)
            {
                return;
            }
            else
            {
                DataRowView rowView = (DataRowView)DataServices.SelectedItem;
                Services.id_ser = Convert.ToInt32(rowView["ID"]);

                Services.dt_days = new DataTable();
                GetDays.Get();
                DataDays.ItemsSource = Services.dt_days.AsDataView();

                Services.dt_services = new DataTable();
                ClientsData.fullname = ClientList.Text;
                GetContract.Get();
                DataServices.ItemsSource = Services.dt_services.AsDataView();
            }
        }
    }
}
