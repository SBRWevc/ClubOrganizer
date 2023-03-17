using ClubOrganizer.Pages.List_black.Class;
using ClubOrganizer.Pages.List_clients.Class;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.List_black
{
    public partial class List_black : Page
    {
        readonly Main main;
        bool Process = false;

        public List_black(Main owner)
        {
            main = owner;
            InitializeComponent();
            Update_data();
            Animation();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            DataRowView rowView = (DataRowView)Data_clients.SelectedItem;
            BlockData.id = Convert.ToString(rowView["ID"]);
            GetInfo.Block_info();
            Reason.Text = BlockData.reason;
            Date.Text = BlockData.date;
            Main_Dialog.IsOpen = true;

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.HideSideBar();
            }
        }

        private async void UnBlock_Click(object sender, RoutedEventArgs e)
        {
            if (Data_clients.SelectedItem == null)
            {
                return;
            }
            else
            {
                DataRowView rowView = (DataRowView)Data_clients.SelectedItem;
                BlockData.id = Convert.ToString(rowView["ID"]);
                UnBlcClient.Unblock();
                Update_data();

                if (Process != true)
                {
                    Process = true;

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.UserOutline;
                    Icon.Foreground = Brushes.Coral;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(620, 0, 0, 30),
                        To = new Thickness(620, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(620, 0, 0, -90),
                        To = new Thickness(620, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(620, 0, 0, -90),
                        To = new Thickness(620, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(620, 0, 0, 30),
                        To = new Thickness(620, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                    Process = false;
                }
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
                    From = new Thickness(620, 0, 0, 30),
                    To = new Thickness(620, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(620, 0, 0, -90),
                    To = new Thickness(620, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(620, 0, 0, -90),
                    To = new Thickness(620, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(620, 0, 0, 30),
                    To = new Thickness(620, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private void Client_list_GotFocus(object sender, RoutedEventArgs e)
        {
            BlockData.lt_clients = new();
            GetBlockClientList.Get(Client_list);
            Client_list.ItemsSource = BlockData.lt_clients.AsDataView();
            Client_list.DisplayMemberPath = "fullname";
            Client_list.SelectedValuePath = "id";
        }

        private async void Client_search_Click(object sender, RoutedEventArgs e)
        {
            if (Client_list.Text != "")
            {
                if (Process != true)
                {
                    Process = true;

                    BlockData.dt_clients = new DataTable();
                    BlockData.fullname = Client_list.Text;
                    SrchBlockClient.Get();
                    Data_clients.ItemsSource = BlockData.dt_clients.AsDataView();

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                    Icon.Foreground = Brushes.Coral;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(620, 0, 0, 30),
                        To = new Thickness(620, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(620, 0, 0, -90),
                        To = new Thickness(620, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(620, 0, 0, -90),
                        To = new Thickness(620, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(620, 0, 0, 30),
                        To = new Thickness(620, 0, 0, -90),
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
                    From = new Thickness(620, 0, 0, 30),
                    To = new Thickness(620, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(620, 0, 0, -90),
                    To = new Thickness(620, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(620, 0, 0, -90),
                    To = new Thickness(620, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(620, 0, 0, 30),
                    To = new Thickness(620, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        internal void Update_data()
        {
            BlockData.dt_clients = new();
            GetBlocClients.Get();
            Data_clients.ItemsSource = BlockData.dt_clients.AsDataView();
        }

        private async void Animation()
        {
            if (Process != true)
            {
                Process = true;

                await Task.Delay(800);
                ThicknessAnimation MGanimation = new()
                {
                    From = new Thickness(620, 0, 0, -90),
                    To = new Thickness(620, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);

                ThicknessAnimation MGanimationSearch = new()
                {
                    From = new Thickness(-220, 0, 0, -90),
                    To = new Thickness(-220, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                BottombarSearch.BeginAnimation(MarginProperty, MGanimationSearch);

                Process = false;
            }
        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            Main_Dialog.IsOpen = false;

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.ShowSideBar();
            }

            Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.AccountQuestionOutline;
            Icon.Foreground = Brushes.Black;

            ThicknessAnimation MGanimationBar = new()
            {
                From = new Thickness(620, 0, 0, 30),
                To = new Thickness(620, 0, 0, -90),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

            ThicknessAnimation MGanimationSuc = new()
            {
                From = new Thickness(620, 0, 0, -90),
                To = new Thickness(620, 0, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Succes.BeginAnimation(MarginProperty, MGanimationSuc);

            await Task.Delay(4500);

            ThicknessAnimation MGanimationBarBack = new()
            {
                From = new Thickness(620, 0, 0, -90),
                To = new Thickness(620, 0, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

            ThicknessAnimation MGanimationSucBack = new()
            {
                From = new Thickness(620, 0, 0, 30),
                To = new Thickness(620, 0, 0, -90),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
        }
    }
}
