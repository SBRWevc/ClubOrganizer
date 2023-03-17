using ClubOrganizer.Pages.List_contracts.Class;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.List_contracts
{
    public partial class List_contracts : Page
    {
        readonly Main main;
        bool Process = false;

        public List_contracts(Main owner)
        {
            main = owner;

            InitializeComponent();

            Update_data();
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
                    From = new Thickness(740, 0, 0, -90),
                    To = new Thickness(740, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);

                ThicknessAnimation MGanimationSearch = new()
                {
                    From = new Thickness(-160, 0, 0, -90),
                    To = new Thickness(-160, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                BottombarSearch.BeginAnimation(MarginProperty, MGanimationSearch);

                Process = false;
            }
        }

        internal void Update_data()
        {
            Contracts.dt_contracts = new();
            GetContracts.Get();
            DataContracts.ItemsSource = Contracts.dt_contracts.AsDataView();
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
                    From = new Thickness(740, 0, 0, 30),
                    To = new Thickness(740, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(740, 0, 0, -90),
                    To = new Thickness(740, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(740, 0, 0, -90),
                    To = new Thickness(740, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(740, 0, 0, 30),
                    To = new Thickness(740, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private async void ClientSearch_Click(object sender, RoutedEventArgs e)
        {
            if (ClientList.Text != "")
            {
                Contracts.dt_contracts = new DataTable();
                ClientsData.fullname = ClientList.Text;
                SrchContract.Get();
                DataContracts.ItemsSource = Contracts.dt_contracts.AsDataView();

                if (Process != true)
                {
                    Process = true;

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                    Icon.Foreground = Brushes.Coral;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(740, 0, 0, 30),
                        To = new Thickness(740, 0, 0, -90),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(740, 0, 0, -90),
                        To = new Thickness(740, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(740, 0, 0, -90),
                        To = new Thickness(740, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(740, 0, 0, 30),
                        To = new Thickness(740, 0, 0, -90),
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
                Update_data();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
                Icon.Foreground = Brushes.Black;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(740, 0, 0, 30),
                    To = new Thickness(740, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(740, 0, 0, -90),
                    To = new Thickness(740, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(740, 0, 0, -90),
                    To = new Thickness(740, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(740, 0, 0, 30),
                    To = new Thickness(740, 0, 0, -90),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

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

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            if (DataContracts.SelectedItem == null)
            {
                return;
            }
            else
            {
                string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string path = doc + @"\Ладога\Docx\Договоры\Temp";

                DirectoryInfo dirInfo = new(path);
                if (dirInfo.Exists)
                {
                    Directory.Delete(path, true);
                }

                DataRowView rowView = (DataRowView)DataContracts.SelectedItem;
                Contracts.id = Convert.ToInt32(rowView["ID"]);

                DataContract.GetInfo();

                Update_data();
            }
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            if (DataContracts.SelectedItem == null)
            {
                return;
            }
            else
            {
                DataRowView rowView = (DataRowView)DataContracts.SelectedItem;
                Contracts.id = Convert.ToInt32(rowView["ID"]);

                RestContract.Get();

                Rest.Text = Contracts.rest;
                
                Main_Dialog.IsOpen = true;

                if (Main.Animation != true)
                {
                    Main.Animation = true;

                    main.HideSideBar();
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Rest.Text = "";
            Main_Dialog.IsOpen = false;

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.ShowSideBar();
            }
        }

        private async void PayRest_Click(object sender, RoutedEventArgs e)
        {
            if (Rest.Text != "")
            {
                Contracts.payRest = Sum.Text;

                if (Convert.ToInt32(Contracts.rest) >= Convert.ToInt32(Contracts.payRest))
                {
                    Class.PayRest.Pay();

                    Rest.Text = "";
                    Main_Dialog.IsOpen = false;

                    if (Main.Animation != true)
                    {
                        Main.Animation = true;

                        main.ShowSideBar();
                    }

                    Update_data();
                }
                else
                {
                    Rest.Foreground = Brushes.Red;

                    await Task.Delay(2500);

                    Rest.Foreground = Brushes.Black;
                }
            }
            else
            {
                Rest.Text = "";
                Main_Dialog.IsOpen = false;

                if (Main.Animation != true)
                {
                    Main.Animation = true;

                    main.ShowSideBar();
                }
            }
        }

        private void Refund_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
