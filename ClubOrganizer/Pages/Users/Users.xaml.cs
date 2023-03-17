using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.Users
{
    public partial class Users : Page
    {
        readonly Main main;
        bool Process = false;

        public Users(Main owner)
        {
            main = owner;
            InitializeComponent();
            Animation();
            Get_users_info();
        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Data_users.SelectedItem == null)
            {
                return;
            }
            else
            {
                if (Process != true)
                {
                    Process = true;

                    DataRowView rowView = (DataRowView)Data_users.SelectedItem;
                    ClubOrganizer.Users.id = Convert.ToString(rowView["ID"]);
                    Class.DelUser.Del();
                    Get_users_info();

                    Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
                    Icon.Foreground = Brushes.Black;

                    ThicknessAnimation MGanimationBar = new()
                    {
                        From = new Thickness(108, 0, 0, 30),
                        To = new Thickness(108, 0, 0, -70),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                    ThicknessAnimation MGanimationSuc = new()
                    {
                        From = new Thickness(108, 0, 0, -70),
                        To = new Thickness(108, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                    await Task.Delay(4500);

                    ThicknessAnimation MGanimationBarBack = new()
                    {
                        From = new Thickness(108, 0, 0, -70),
                        To = new Thickness(108, 0, 0, 30),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                    ThicknessAnimation MGanimationSucBack = new()
                    {
                        From = new Thickness(108, 0, 0, 30),
                        To = new Thickness(108, 0, 0, -70),
                        Duration = new Duration(TimeSpan.FromSeconds(0.8))
                    };
                    Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                    Process = false;
                }
            }
        }

        private async void Check_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                Class.UpdUser.Change_info();

                Get_users_info();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                Icon.Foreground = Brushes.Coral;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                Get_users_info();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                Icon.Foreground = Brushes.Coral;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            main.Main_Frame.Navigate(new NewUser.CreateUser(this));
        }

        private async void Animation()
        {
            await Task.Delay(800);
            ThicknessAnimation MGanimation = new()
            {
                From = new Thickness(108, 0, 0, -70),
                To = new Thickness(108, 0, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            Bottombar.BeginAnimation(MarginProperty, MGanimation);
        }


        internal void Page_Return()
        {
            main.Main_Frame.Navigate(new Users(main));
        }

        internal void Error_NewUser()
        {
            main.Error();
        }

        internal void Get_users_info()
        {
            ClubOrganizer.Users.dt_users = new();
            Class.GetUsers.Get_info();
            Data_users.ItemsSource = ClubOrganizer.Users.dt_users.AsDataView();
        }
    }
}
