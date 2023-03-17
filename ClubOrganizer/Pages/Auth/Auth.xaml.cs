using ClubOrganizer.Pages.Auth.Class;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.Auth
{
    public partial class Auth : Page
    {
        readonly Main main;
        public Auth(Main owner)
        {
            main = owner;

            InitializeComponent();

            var backgroung = Brushes.Transparent.Clone();
            Main_Back.Background = backgroung;

            ColorAnimation animation = new()
            {
                From = Colors.Transparent,
                To = Colors.Coral,
                Duration = new Duration(TimeSpan.FromSeconds(0.5))
            };
            backgroung.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            InputLanguageManager.SetInputLanguage(Auth_Login, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Auth_Pass, CultureInfo.CreateSpecificCulture("en"));

            InputLanguageManager.SetInputLanguage(Reg_Lastname, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Reg_Name, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Reg_Secondname, CultureInfo.CreateSpecificCulture("ru"));
            InputLanguageManager.SetInputLanguage(Reg_Login, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Reg_Pass, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Reg_PassConf, CultureInfo.CreateSpecificCulture("en"));

            InputLanguageManager.SetInputLanguage(Conf_Login, CultureInfo.CreateSpecificCulture("en"));
            InputLanguageManager.SetInputLanguage(Conf_Pass, CultureInfo.CreateSpecificCulture("en"));
        }

        private void Form_Auth_Click(object sender, RoutedEventArgs e)
        {
            Reg_Lastname.Text = "";
            Reg_Name.Text = "";
            Reg_Secondname.Text = "";
            Reg_Position.Text = "";
            Reg_Login.Text = "";
            Reg_Pass.Password = "";
            Reg_PassConf.Password = "";

            Conf_Login.Text = "";
            Conf_Pass.Password = "";

            var backgroung = Brushes.Green.Clone();
            Main_Back.Background = backgroung;

            ColorAnimation BGanimation = new()
            {
                From = Colors.Green,
                To = Colors.Coral,
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            backgroung.BeginAnimation(SolidColorBrush.ColorProperty, BGanimation);

            var foregroungAuth = Brushes.Green.Clone();
            var foregroungReg = Brushes.Green.Clone();
            Form_Auth.Foreground = foregroungAuth;
            Form_Reg.Foreground = foregroungReg;

            ColorAnimation FGanimation = new()
            {
                From = Colors.Green,
                To = Colors.Coral,
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            foregroungAuth.BeginAnimation(SolidColorBrush.ColorProperty, FGanimation);
            foregroungReg.BeginAnimation(SolidColorBrush.ColorProperty, FGanimation);

            ThicknessAnimation TKanimation = new()
            {
                From = new Thickness(400, 0, 0, 0),
                To = new Thickness(0, 0, 400, 0),
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };
            FormAn.BeginAnimation(MarginProperty, TKanimation);

            ThicknessAnimation MGanimationAuth = new()
            {
                From = new Thickness(0, 0, 800, 0),
                To = new Thickness(0, 0, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Data_Auth.BeginAnimation(MarginProperty, MGanimationAuth);

            ThicknessAnimation MGanimationReg = new()
            {
                From = new Thickness(0, 0, 0, 0),
                To = new Thickness(800, 0, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Data_Reg.BeginAnimation(MarginProperty, MGanimationReg);
        }

        private void Form_Reg_Click(object sender, RoutedEventArgs e)
        {
            Auth_Login.Text = "";
            Auth_Pass.Password = "";

            var backgroung = Brushes.Coral.Clone();
            Main_Back.Background = backgroung;

            ColorAnimation animation = new()
            {
                From = Colors.Coral,
                To = Colors.Green,
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            backgroung.BeginAnimation(SolidColorBrush.ColorProperty, animation);

            var foregroungAuth = Brushes.Coral.Clone();
            var foregroungReg = Brushes.Coral.Clone();
            Form_Auth.Foreground = foregroungAuth; 
            Form_Reg.Foreground = foregroungReg;

            ColorAnimation FGanimation = new()
            {
                From = Colors.Coral,
                To = Colors.Green,
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            foregroungAuth.BeginAnimation(SolidColorBrush.ColorProperty, FGanimation);
            foregroungReg.BeginAnimation(SolidColorBrush.ColorProperty, FGanimation);

            ThicknessAnimation TKanimation = new()
            {
                From = new Thickness(0, 0, 400, 0),
                To = new Thickness(400, 0, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            FormAn.BeginAnimation(MarginProperty, TKanimation);

            ThicknessAnimation MGanimationAuth = new()
            {
                From = new Thickness(0, 0, 0, 0),
                To = new Thickness(0, 0, 800, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Data_Auth.BeginAnimation(MarginProperty, MGanimationAuth);

            ThicknessAnimation MGanimationReg = new()
            {
                From = new Thickness(800, 0, 0, 0),
                To = new Thickness(0, 0, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Data_Reg.BeginAnimation(MarginProperty, MGanimationReg);
        }

        private void Btn_auth_Click(object sender, RoutedEventArgs e)
        {
            if (Auth_Login.Text == "" && Auth_Pass.Password == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не ввели данные";
                main.Error();
            }
            else if (Auth_Login.Text == "" || Auth_Pass.Password == "")
            {
                if (Auth_Login.Text == "")
                {
                    Errors.AuthError = "Вы не ввели логин";
                    main.Error();
                }
                else
                {
                    Errors.AuthError = "Вы не ввели пароль";
                    main.Error();
                }
            }
            else
            {
                AuthData.Login = Auth_Login.Text.Trim().ToLower();
                AuthData.Pass = Auth_Pass.Password.Trim().ToLower();

                Class.Auth.DataCheck();

                if (AuthData.ok == true)
                {
                    Class.Userdata.Get_info();
                    AuthData.ok = false;
                    main.Enter();
                }
                else
                {
                    Errors.AuthError = "Вы ввели неверные данные";
                    main.Error();
                }
            }
        }

        private void Btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if (Reg_Lastname.Text == "" && Reg_Name.Text == "" && Reg_Secondname.Text == "" &&
                Reg_Position.Text == "" && Reg_Login.Text == "" && Reg_Pass.Password == "" && Reg_PassConf.Password == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не ввели данные";
                main.Error();
            }
            else if (Reg_Lastname.Text == "" || Reg_Name.Text == "" || Reg_Secondname.Text == "" ||
                Reg_Position.Text == "" || Reg_Login.Text == "" || Reg_Pass.Password == "" || Reg_PassConf.Password == "")
            {
                if (Reg_Lastname.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели фамилию";
                    main.Error();
                }
                else if (Reg_Name.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели имя";
                    main.Error();
                }
                else if (Reg_Secondname.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели отчество";
                    main.Error();
                }
                else if (Reg_Position.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не выбрали должность";
                    main.Error();
                }
                else if (Reg_Login.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели логин";
                    main.Error();
                }
                else if (Reg_Pass.Password == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели пароль";
                    main.Error();
                }
                else if (Reg_PassConf.Password == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не подтвердили пароль";
                    main.Error();
                }                
            }
            else
            {
                if (Reg_Pass.Password != Reg_PassConf.Password)
                {
                    ClubOrganizer.Errors.AuthError = "Пароли не совпадают";
                    main.Error();
                }
                else
                {
                    Conf_Dialog.IsOpen = true;
                }
            }
        }

        private void Conf_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Conf_Login.Text == "" && Conf_Pass.Password == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не ввели данные";
                main.Error();
            }
            else if (Conf_Login.Text == "" || Conf_Pass.Password == "")
            {
                if (Conf_Login.Text == "")
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели логин";
                    main.Error();
                }
                else
                {
                    ClubOrganizer.Errors.AuthError = "Вы не ввели пароль";
                    main.Error();
                }
            }
            else
            {
                AuthData.Login = Conf_Login.Text.Trim().ToLower();
                AuthData.Pass = Conf_Pass.Password.Trim().ToLower();

                Class.Auth.DataCheck();

                if (AuthData.ok == true)
                {
                    if (Reg_Lastname.Text[^1..] == "а")
                    {
                        RegData.Gender = "Женский";
                    }
                    else
                    {
                        RegData.Gender = "Мужской";
                    }

                    RegData.Lastname = Reg_Lastname.Text;
                    RegData.Name = Reg_Name.Text;
                    RegData.Secondname = Reg_Secondname.Text;
                    RegData.Position = Reg_Position.Text;
                    RegData.Login = Reg_Login.Text.Trim().ToLower();
                    RegData.Pass = Reg_Pass.Password.Trim().ToLower();

                    Registration.New_user();

                    Conf_Dialog.IsOpen = false;
                    LoopVisualTree(this);

                    AuthData.Login = "";
                    AuthData.Pass = "";
                    Userdata.id = 0;
                }
                else
                {
                    ClubOrganizer.Errors.AuthError = "Вы ввели неверные данные";
                    main.Error();
                }
            }
        }

        private void LoopVisualTree(DependencyObject obj)//обнуление текст боксов
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                if (obj is TextBox box)
                {
                    box.Text = "";
                }

                if (obj is PasswordBox password)
                {
                    password.Password = "";
                }

                if (obj is ComboBox combo)
                {
                    combo.Text = "";
                }
                // РЕКУРСИЯ
                LoopVisualTree(VisualTreeHelper.GetChild(obj, i));
            }
        }
    }
}
