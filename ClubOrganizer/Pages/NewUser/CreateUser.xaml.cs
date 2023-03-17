using ClubOrganizer.Functions.Clear;
using ClubOrganizer.Pages.NewUser.Class;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace ClubOrganizer.Pages.NewUser
{
    public partial class CreateUser : Page
    {
        readonly Users.Users main;
        bool Process = false;

        public CreateUser(Users.Users owner)
        {
            main = owner;
            InitializeComponent();
            Animation();

            InputLanguageManager.SetInputLanguage(Login, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Pass, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Lastname, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Username, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Secondname, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Position, CultureInfo.CreateSpecificCulture("ru"));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            NewDataUser.Lastname = Lastname.Text.Trim();
            NewDataUser.Username = Username.Text.Trim();
            NewDataUser.Secondname = Secondname.Text.Trim();
            NewDataUser.Position = Position.Text.Trim();
            NewDataUser.Login = Login.Text.Trim().ToLower(); ;
            NewDataUser.Pass = Pass.Password.Trim().ToLower();

            // Проверки \\
            if (NewDataUser.Lastname == "" && NewDataUser.Username == "" && NewDataUser.Secondname == "" &&
                NewDataUser.Position == "" && NewDataUser.Login == "" && NewDataUser.Pass == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не заполнили данные";
                main.Error_NewUser();
            }
            else if (NewDataUser.Lastname == "" || NewDataUser.Username == "" || NewDataUser.Secondname == "" ||
                NewDataUser.Position == "" || NewDataUser.Login == "" || NewDataUser.Pass == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы заполнили не все данные";
                main.Error_NewUser();
            }
            else
            {
                LoginCheck.Check();

                if (NewDataUser.Login_state == false)
                {
                    Errors.AuthError = "Такой логин уже используется";
                    main.Error_NewUser();
                }
                else
                {
                    CrtUser.New_user();

                    Inputs.ClearInputs(this);

                    main.Page_Return();
                }
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

        private void Man_Click(object sender, RoutedEventArgs e)
        {
            USR_avatar.Source = new BitmapImage(new Uri("/resources/avatar/man.png", UriKind.Relative));
            NewDataUser.Gender = "Мужской";
        }

        private void Woman_Click(object sender, RoutedEventArgs e)
        {
            USR_avatar.Source = new BitmapImage(new Uri("/resources/avatar/woman.png", UriKind.Relative));
            NewDataUser.Gender = "Женский";
        }

        private void Secondname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Secondname.Text != "")
            {
                Binding binding = new()
                {
                    ElementName = "Secondname",
                    Path = new PropertyPath("Text")
                };
                Secondname_text.SetBinding(TextBlock.TextProperty, binding);
            }
            else
            {
                Secondname_text.Text = "Отчество";
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Username.Text != "")
            {
                Binding binding = new()
                {
                    ElementName = "Username",
                    Path = new PropertyPath("Text")
                };
                Name_text.SetBinding(TextBlock.TextProperty, binding);
            }
            else
            {
                Name_text.Text = "Имя";
            }
        }

        private void Lastname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Lastname.Text != "")
            {
                Binding binding = new()
                {
                    ElementName = "Lastname",
                    Path = new PropertyPath("Text")
                };
                Lastname_text.SetBinding(TextBlock.TextProperty, binding);
            }
            else
            {
                Lastname_text.Text = "Фамилия";
            }
        }

        private void Position_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Position.Text != "")
            {
                Binding binding = new()
                {
                    ElementName = "Position",
                    Path = new PropertyPath("Text")
                };
                Position_text.SetBinding(TextBlock.TextProperty, binding);
            }
            else
            {
                Position_text.Text = "Должность";
            }
        }

        private async void Animation()
        {
            await Task.Delay(800);
            ThicknessAnimation MGanimation = new()
            {
                From = new Thickness(0, 0, 0, -70),
                To = new Thickness(0, 0, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            Bottombar.BeginAnimation(MarginProperty, MGanimation);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Inputs.ClearInputs(this);

            main.Page_Return();
        }
    }
}
