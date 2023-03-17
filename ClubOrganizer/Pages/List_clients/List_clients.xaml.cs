using ClubOrganizer.Pages.List_clients.Class;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.List_clients
{
    public partial class List_clients : Page
    {
        readonly Main main;
        bool Process = false;

        public List_clients(Main owner)
        {
            main = owner;

            InitializeComponent();
            Animation();
            Update_data();
        }

        private void Client_list_GotFocus(object sender, RoutedEventArgs e)
        {
            ClientsData.lt_clients = new();
            GetClientsList.Get();
            Client_list.ItemsSource = ClientsData.lt_clients.AsDataView();
            Client_list.DisplayMemberPath = "fullname";
            Client_list.SelectedValuePath = "id";
        }

        internal void Update_data()
        {
            ClientsData.dt_clients = new();
            GetClients.Get();
            Data_clients.ItemsSource = ClientsData.dt_clients.AsDataView();
        }

        private async void Client_search_Click(object sender, RoutedEventArgs e)
        {
            if (Client_list.Text != "")
            {
                ClientsData.dt_clients = new DataTable();
                ClientsData.fullname = Client_list.Text;
                SrchClient.Get();
                Data_clients.ItemsSource = ClientsData.dt_clients.AsDataView();

                if (Process != true)
                {
                    Process = true;

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                    Icon.Foreground = Brushes.Coral;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(670, 0, 0, 30),
                        To = new Thickness(670, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(670, 0, 0, -90),
                        To = new Thickness(670, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(670, 0, 0, -90),
                        To = new Thickness(670, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(670, 0, 0, 30),
                        To = new Thickness(670, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                    Process = false;
                }
            }
        }

        private async void Client_reset_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                Client_list.Text = "";
                Update_data();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
                Icon.Foreground = Brushes.Black;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private void Block_Click(object sender, RoutedEventArgs e)
        {
            if (Data_clients.SelectedItem == null)
            {
                return;
            }
            else
            {
                DataRowView rowView = (DataRowView)Data_clients.SelectedItem;
                ClientsData.id = Convert.ToString(rowView["ID"]);
                Main_Dialog.IsOpen = true;

                if (Main.Animation != true)
                {
                    Main.Animation = true;

                    main.HideSideBar();
                }
            }
        }

        private async void Animation()
        {
            if (Process != true)
            {
                Process = true;

                await Task.Delay(800);
                ThicknessAnimation MGanimation = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);

                ThicknessAnimation MGanimationSearch = new()
                {
                    From = new Thickness(-90, 0, 0, -90),
                    To = new Thickness(-90, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                BottombarSearch.BeginAnimation(MarginProperty, MGanimationSearch);

                Process = false;
            }
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                Update_data();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                Icon.Foreground = Brushes.Coral;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Block_reason.Text = "";
            Main_Dialog.IsOpen = false;

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.ShowSideBar();
            }
        }
        private async void Disable_Click(object sender, RoutedEventArgs e)
        {

            ClientsData.reason = Block_reason.Text;
            ClientsData.date = Block_date.Text;
            BlockInfo.Info();
            BlcClient.Block();
            Update_data();

            Main_Dialog.IsOpen = false;
            Block_reason.Text = "";

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.ShowSideBar();
            }

            if (Process != true)
            {
                Process = true;

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.UserBlockOutline;
                Icon.Foreground = Brushes.Black;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(670, 0, 0, -90),
                    To = new Thickness(670, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(670, 0, 0, 30),
                    To = new Thickness(670, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }
    }
}
