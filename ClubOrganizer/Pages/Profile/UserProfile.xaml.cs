using ClubOrganizer.Functions.Clear;
using ClubOrganizer.Pages.Profile.Class;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace ClubOrganizer.Pages.Profile
{
    public partial class UserProfile : Page
    {
        bool Process = false;

        public UserProfile()
        {
            InitializeComponent();
            WN_auth();
            Animation();
        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Userdata.Login == PRF_login.Text && PRF_pass.Password.Trim().ToLower() == "")
            {
                
            }
            else if (Userdata.Login != PRF_login.Text && PRF_pass.Password.Trim().ToLower() == "")
            {
                Userdata.Login = PRF_login.Text.Trim().ToLower();
                UpdUser.Login_update();
                WN_auth();

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DoneOutline;
                Icon.Foreground = Brushes.Coral;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
            }
            else if (Userdata.Login == PRF_login.Text && PRF_pass.Password.Trim().ToLower() != "")
            {
                Userdata.Pass = PRF_pass.Password.Trim().ToLower();
                UpdUser.Pass_update();
                WN_auth();

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
            }
            else
            {
                Userdata.Login = PRF_login.Text.Trim().ToLower();
                Userdata.Pass = PRF_pass.Password.Trim().ToLower();
                UpdUser.All_update();
                WN_auth();

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
            }
        }

        private void WN_auth()
        {
            PRF_fullname.Text = Userdata.Lastname + " " +
                Userdata.Name + " " + Userdata.Secondname;
            PRF_position.Text = Userdata.Position;
            PRF_login.Text = Userdata.Login;

            if (Userdata.Gender == "Женский")
            {
                PRF_avatar.Source = new BitmapImage(new Uri
                    ("/resources/avatar/woman.png", UriKind.Relative));
            }
            else if (Userdata.Gender == "Мужской")
            {
                if (PRF_fullname.Text == "Ляхов Дмитрий Сергеевич")
                {
                    PRF_avatar.Source = new BitmapImage(new Uri
                    ("/resources/avatar/dev.png", UriKind.Relative));
                }
                else
                {
                    PRF_avatar.Source = new BitmapImage(new Uri
                        ("/resources/avatar/man.png", UriKind.Relative));
                }
            }
            else
            {
                PRF_avatar.Source = new BitmapImage(new Uri
                    ("/resources/avatar/neutral.png", UriKind.Relative));
            }
        }

        private async void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (Process != true)
            {
                Process = true;

                Inputs.ClearInputs(this);

                Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
                Icon.Foreground = Brushes.Black;

                ThicknessAnimation MGanimationBar = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBar);

                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationBarBack = new()
                {
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimationBarBack);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(0, 0, 0, 30),
                    To = new Thickness(0, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);

                Process = false;
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
                    From = new Thickness(0, 0, 0, -70),
                    To = new Thickness(0, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);

                Process = false;
            }
        }
    }
}
