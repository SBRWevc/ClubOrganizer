using ClubOrganizer.Functions.First;
using ClubOrganizer.Pages.Fast_Rent;
using ClubOrganizer.Pages.Fast_Tennis;
using ClubOrganizer.Pages.Go2Sport;
using ClubOrganizer.Pages.Greeting;
using ClubOrganizer.Pages.List_black;
using ClubOrganizer.Pages.List_clients;
using ClubOrganizer.Pages.List_contracts;
using ClubOrganizer.Pages.List_services;
using ClubOrganizer.Pages.Mail;
using ClubOrganizer.Pages.Payment;
using ClubOrganizer.Pages.Screensaver;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace ClubOrganizer
{
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();

            Loading();

            this.VisualTextRenderingMode = TextRenderingMode.ClearType;
            Sidebar.Height = SystemParameters.PrimaryScreenHeight - 60;
        }

        internal static bool Animation = false;

        private async void Loading()
        {
            Progress.Visibility = Visibility.Visible;
            Frame.Visibility = Visibility.Collapsed;

            await Task.Delay(5000);

            Progress.Visibility = Visibility.Collapsed;
            Frame.Visibility = Visibility.Visible;

            Main_Frame.Navigate(new Pages.Auth.Auth(this));
        }


        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Go2Sport_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 1)
            {
                var foreground = new SolidColorBrush(Colors.White);
                Go2Sport.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Colors.White,
                    To = Colors.Coral,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                if (Errors.Page == 2)
                {
                    var foregroundMail = new SolidColorBrush(Colors.Coral);
                    Mail.Foreground = foregroundMail;

                    ColorAnimation CLanimationMail = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                }

                if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                {
                    var foregroundContracts = new SolidColorBrush(Colors.Coral);
                    Contracts.Foreground = foregroundContracts;

                    ColorAnimation CLanimationContracts = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                }

                if (Errors.Page == 7 || Errors.Page == 8)
                {
                    var foregroundClients = new SolidColorBrush(Colors.Coral);
                    Clients.Foreground = foregroundClients;

                    ColorAnimation CLanimationClients = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                }

                if (Errors.Page == 9)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Payment.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                }

                if (Errors.Page == 10 || Errors.Page == 11)
                {
                    var foregroundProfile = new SolidColorBrush(Colors.Coral);
                    Profile.Foreground = foregroundProfile;

                    ColorAnimation CLanimationProfile = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                }

                if (Errors.Page == 12)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Settings.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                    DoubleAnimation RTanimationSet = new()
                    {
                        From = 180,
                        To = 360,
                        Duration = new Duration(TimeSpan.FromSeconds(1.2))
                    };
                    Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                }

                Main_Frame.Navigate(new Go2Sport());

                Errors.Page = 1;
            }
        }
        private void Mail_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 2)
            {
                Main_Frame.NavigationService.RemoveBackEntry();
                var foreground = new SolidColorBrush(Colors.White);
                Mail.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Colors.White,
                    To = Colors.Coral,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                if (Errors.Page == 1)
                {
                    var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                    Go2Sport.Foreground = foregroundGo2;

                    ColorAnimation CLanimationGo2 = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                }

                if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                {
                    var foregroundContracts = new SolidColorBrush(Colors.Coral);
                    Contracts.Foreground = foregroundContracts;

                    ColorAnimation CLanimationContracts = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                }

                if (Errors.Page == 7 || Errors.Page == 8)
                {
                    var foregroundClients = new SolidColorBrush(Colors.Coral);
                    Clients.Foreground = foregroundClients;

                    ColorAnimation CLanimationClients = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                }

                if (Errors.Page == 9)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Payment.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                }

                if (Errors.Page == 10 || Errors.Page == 11)
                {
                    var foregroundProfile = new SolidColorBrush(Colors.Coral);
                    Profile.Foreground = foregroundProfile;

                    ColorAnimation CLanimationProfile = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                }

                if (Errors.Page == 12)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Settings.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                    DoubleAnimation RTanimationSet = new()
                    {
                        From = 180,
                        To = 360,
                        Duration = new Duration(TimeSpan.FromSeconds(1.2))
                    };
                    Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                }

                Main_Frame.Navigate(new Mail());

                Errors.Page = 2;
            }
        }
        private void Fast_Tennis_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 3 || Errors.Page != 4 || Errors.Page != 5 || Errors.Page != 6)
            {
                if (Errors.Page != 3)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Contracts.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 3;

                    Main_Frame.Navigate(new Fast_Tennis(this));
                }
            }
        }
        private void Fast_Rent_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 3 || Errors.Page != 4 || Errors.Page != 5 || Errors.Page != 6)
            {
                if (Errors.Page != 4)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Contracts.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 4;

                    Main_Frame.Navigate(new Fast_Rent());
                }
            }
        }
        private void Contracts_List_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 3 || Errors.Page != 4 || Errors.Page != 5 || Errors.Page != 6)
            {
                if (Errors.Page != 5)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Contracts.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 5;

                    Main_Frame.Navigate(new List_contracts(this));
                }
            }
        }
        private void Service_List_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 3 || Errors.Page != 4 || Errors.Page != 5 || Errors.Page != 6)
            {
                if (Errors.Page != 6)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Contracts.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 6;

                    Main_Frame.Navigate(new List_services());
                }
            }
        }
        private void Client_List_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 7 || Errors.Page != 8)
            {
                if (Errors.Page != 7)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Clients.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                    {
                        var foregroundContracts = new SolidColorBrush(Colors.Coral);
                        Contracts.Foreground = foregroundContracts;

                        ColorAnimation CLanimationContracts = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 7;

                    Main_Frame.Navigate(new List_clients(this));
                }
            }
        }
        private void Black_List_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 7 || Errors.Page != 8)
            {
                if (Errors.Page != 8)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Colors.White);
                    Clients.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Colors.White,
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                    {
                        var foregroundContracts = new SolidColorBrush(Colors.Coral);
                        Contracts.Foreground = foregroundContracts;

                        ColorAnimation CLanimationContracts = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 10 || Errors.Page == 11)
                    {
                        var foregroundProfile = new SolidColorBrush(Colors.Coral);
                        Profile.Foreground = foregroundProfile;

                        ColorAnimation CLanimationProfile = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 8;

                    Main_Frame.Navigate(new List_black(this));
                }
            }
        }
        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 9)
            {
                Main_Frame.NavigationService.RemoveBackEntry();
                var foreground = new SolidColorBrush(Colors.White);
                Payment.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Colors.White,
                    To = Colors.Coral,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                if (Errors.Page == 1)
                {
                    var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                    Go2Sport.Foreground = foregroundGo2;

                    ColorAnimation CLanimationGo2 = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                }

                if (Errors.Page == 2)
                {
                    var foregroundMail = new SolidColorBrush(Colors.Coral);
                    Mail.Foreground = foregroundMail;

                    ColorAnimation CLanimationMail = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                }

                if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                {
                    var foregroundContracts = new SolidColorBrush(Colors.Coral);
                    Contracts.Foreground = foregroundContracts;

                    ColorAnimation CLanimationContracts = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                }

                if (Errors.Page == 7 || Errors.Page == 8)
                {
                    var foregroundClients = new SolidColorBrush(Colors.Coral);
                    Clients.Foreground = foregroundClients;

                    ColorAnimation CLanimationClients = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                }

                if (Errors.Page == 10 || Errors.Page == 11)
                {
                    var foregroundProfile = new SolidColorBrush(Colors.Coral);
                    Profile.Foreground = foregroundProfile;

                    ColorAnimation CLanimationProfile = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                }

                if (Errors.Page == 12)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Settings.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                    DoubleAnimation RTanimationSet = new()
                    {
                        From = 180,
                        To = 360,
                        Duration = new Duration(TimeSpan.FromSeconds(1.2))
                    };
                    Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                }

                Main_Frame.Navigate(new Payment());

                Errors.Page = 9;
            }
        }
        private void Data_User_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 10 || Errors.Page != 11)
            {
                if (Errors.Page != 10)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Color.FromArgb(222, 0, 0, 0));
                    Profile.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Color.FromArgb(222, 0, 0, 0),
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                    {
                        var foregroundContracts = new SolidColorBrush(Colors.Coral);
                        Contracts.Foreground = foregroundContracts;

                        ColorAnimation CLanimationContracts = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 10;

                    Main_Frame.Navigate(new Pages.Profile.UserProfile());
                }
            }
        }
        private void User_List_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 10 || Errors.Page != 11)
            {
                if (Errors.Page != 11)
                {
                    Main_Frame.NavigationService.RemoveBackEntry();
                    var foreground = new SolidColorBrush(Color.FromArgb(222, 0, 0, 0));
                    Profile.Foreground = foreground;

                    ColorAnimation CLanimation = new()
                    {
                        From = Color.FromArgb(222, 0, 0, 0),
                        To = Colors.Coral,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                    if (Errors.Page == 1)
                    {
                        var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                        Go2Sport.Foreground = foregroundGo2;

                        ColorAnimation CLanimationGo2 = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                    }

                    if (Errors.Page == 2)
                    {
                        var foregroundMail = new SolidColorBrush(Colors.Coral);
                        Mail.Foreground = foregroundMail;

                        ColorAnimation CLanimationMail = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                    }

                    if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                    {
                        var foregroundContracts = new SolidColorBrush(Colors.Coral);
                        Contracts.Foreground = foregroundContracts;

                        ColorAnimation CLanimationContracts = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                    }

                    if (Errors.Page == 7 || Errors.Page == 8)
                    {
                        var foregroundClients = new SolidColorBrush(Colors.Coral);
                        Clients.Foreground = foregroundClients;

                        ColorAnimation CLanimationClients = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                    }

                    if (Errors.Page == 9)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Payment.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Colors.White,
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                    }

                    if (Errors.Page == 12)
                    {
                        var foregroundSet = new SolidColorBrush(Colors.Coral);
                        Settings.Foreground = foregroundSet;

                        ColorAnimation CLanimationSet = new()
                        {
                            From = Colors.Coral,
                            To = Color.FromArgb(222, 0, 0, 0),
                            Duration = new Duration(TimeSpan.FromSeconds(0.5))
                        };
                        foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                        DoubleAnimation RTanimationSet = new()
                        {
                            From = 180,
                            To = 360,
                            Duration = new Duration(TimeSpan.FromSeconds(1.2))
                        };
                        Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
                    }

                    Errors.Page = 11;

                    Main_Frame.Navigate(new Pages.Users.Users(this));
                }
            }
        }
        private void Requisites_Click(object sender, RoutedEventArgs e)
        {
            if (Errors.Page != 12)
            {
                Main_Frame.NavigationService.RemoveBackEntry();
                var foreground = new SolidColorBrush(Color.FromArgb(222, 0, 0, 0));
                Settings.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Color.FromArgb(222, 0, 0, 0),
                    To = Colors.Coral,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                DoubleAnimation RTanimation = new()
                {
                    From = 0,
                    To = 180,
                    Duration = new Duration(TimeSpan.FromSeconds(1.2))
                };
                Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimation);

                if (Errors.Page == 1)
                {
                    var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                    Go2Sport.Foreground = foregroundGo2;

                    ColorAnimation CLanimationGo2 = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
                }

                if (Errors.Page == 2)
                {
                    var foregroundMail = new SolidColorBrush(Colors.Coral);
                    Mail.Foreground = foregroundMail;

                    ColorAnimation CLanimationMail = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
                }

                if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
                {
                    var foregroundContracts = new SolidColorBrush(Colors.Coral);
                    Contracts.Foreground = foregroundContracts;

                    ColorAnimation CLanimationContracts = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
                }

                if (Errors.Page == 7 || Errors.Page == 8)
                {
                    var foregroundClients = new SolidColorBrush(Colors.Coral);
                    Clients.Foreground = foregroundClients;

                    ColorAnimation CLanimationClients = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
                }

                if (Errors.Page == 9)
                {
                    var foregroundSet = new SolidColorBrush(Colors.Coral);
                    Payment.Foreground = foregroundSet;

                    ColorAnimation CLanimationSet = new()
                    {
                        From = Colors.Coral,
                        To = Colors.White,
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
                }

                if (Errors.Page == 10 || Errors.Page == 11)
                {
                    var foregroundProfile = new SolidColorBrush(Colors.Coral);
                    Profile.Foreground = foregroundProfile;

                    ColorAnimation CLanimationProfile = new()
                    {
                        From = Colors.Coral,
                        To = Color.FromArgb(222, 0, 0, 0),
                        Duration = new Duration(TimeSpan.FromSeconds(0.5))
                    };
                    foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
                }

                Main_Frame.Navigate(new Pages.Requisites.Requisites(this));

                Errors.Page = 12;
            }
        }


        private void Contracts_Click(object sender, RoutedEventArgs e)
        {
            Items_contracts.IsSubmenuOpen = true;
        }
        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            Items_clients.IsSubmenuOpen = true;
        }
        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            Items_profile.IsSubmenuOpen = true;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            AuthData.Login = "";
            AuthData.Pass = "";

            Userdata.Login = "";
            Userdata.Pass = "";
            Userdata.Lastname = "";
            Userdata.Name = "";
            Userdata.Secondname = "";
            Userdata.Position = "";
            Userdata.Gender = "";
            Userdata.id = 0;

            ThicknessAnimation MGanimationAuth = new()
            {
                From = new Thickness(20, 30, 0, 30),
                To = new Thickness(-70, 30, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Sidebar.BeginAnimation(MarginProperty, MGanimationAuth);

            if (Errors.Page == 1)
            {
                var foregroundGo2 = new SolidColorBrush(Colors.Coral);
                Go2Sport.Foreground = foregroundGo2;

                ColorAnimation CLanimationGo2 = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundGo2.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationGo2);
            }

            if (Errors.Page == 2)
            {
                var foregroundMail = new SolidColorBrush(Colors.Coral);
                Mail.Foreground = foregroundMail;

                ColorAnimation CLanimationMail = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundMail.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationMail);
            }

            if (Errors.Page == 3 || Errors.Page == 4 || Errors.Page == 5 || Errors.Page == 6)
            {
                var foregroundContracts = new SolidColorBrush(Colors.Coral);
                Contracts.Foreground = foregroundContracts;

                ColorAnimation CLanimationContracts = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundContracts.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationContracts);
            }

            if (Errors.Page == 7 || Errors.Page == 8)
            {
                var foregroundClients = new SolidColorBrush(Colors.Coral);
                Clients.Foreground = foregroundClients;

                ColorAnimation CLanimationClients = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundClients.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationClients);
            }

            if (Errors.Page == 9)
            {
                var foregroundSet = new SolidColorBrush(Colors.Coral);
                Payment.Foreground = foregroundSet;

                ColorAnimation CLanimationSet = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);
            }

            if (Errors.Page == 10 || Errors.Page == 11)
            {
                var foregroundProfile = new SolidColorBrush(Colors.Coral);
                Profile.Foreground = foregroundProfile;

                ColorAnimation CLanimationProfile = new()
                {
                    From = Colors.Coral,
                    To = Color.FromArgb(222, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundProfile.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationProfile);
            }

            if (Errors.Page == 12)
            {
                var foregroundSet = new SolidColorBrush(Colors.Coral);
                Settings.Foreground = foregroundSet;

                ColorAnimation CLanimationSet = new()
                {
                    From = Colors.Coral,
                    To = Color.FromArgb(222, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foregroundSet.BeginAnimation(SolidColorBrush.ColorProperty, CLanimationSet);

                DoubleAnimation RTanimationSet = new()
                {
                    From = 180,
                    To = 360,
                    Duration = new Duration(TimeSpan.FromSeconds(1.2))
                };
                Settings.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimationSet);
            }

            Main_Frame.NavigationService.RemoveBackEntry();

            Main_Frame.Navigate(new Pages.Auth.Auth(this));
        }
        private void Small_Click(object sender, RoutedEventArgs e)
        {
            if (Sidebar.Height != 480)
            {
                Sidebar.VerticalAlignment = VerticalAlignment.Bottom;

                DoubleAnimation WHanimation = new()
                {
                    From = SystemParameters.PrimaryScreenHeight - 60,
                    To = 480,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Sidebar.BeginAnimation(HeightProperty, WHanimation);

                var foreground = new SolidColorBrush(Color.FromArgb(222, 0, 0, 0));
                Arrow.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Colors.White,
                    To = Colors.Coral,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                DoubleAnimation RTanimation = new()
                {
                    From = 0,
                    To = 180,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Arrow.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimation);
            }
            else
            {
                DoubleAnimation WHanimation = new()
                {
                    From = 480,
                    To = SystemParameters.PrimaryScreenHeight - 60,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Sidebar.BeginAnimation(HeightProperty, WHanimation);

                var foreground = new SolidColorBrush(Colors.Coral);
                Arrow.Foreground = foreground;

                ColorAnimation CLanimation = new()
                {
                    From = Colors.Coral,
                    To = Colors.White,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                foreground.BeginAnimation(SolidColorBrush.ColorProperty, CLanimation);

                DoubleAnimation RTanimation = new()
                {
                    From = 180,
                    To = 360,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Arrow.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, RTanimation);
            }
        }


        internal async void Error()
        {
            Error_Title.Text = Errors.AuthError;
            Main_Dialog.IsOpen = true;

            await Task.Delay(3200);

            Main_Dialog.IsOpen = false;
        }
        internal async void Enter()
        {
            ReqCheck.Check();

            if (ClubOrganizer.Requisites.lastname == "" || ClubOrganizer.Requisites.name == "" ||
                ClubOrganizer.Requisites.secondname == "")
            {
                Main_Frame.Navigate(new Pages.Requisites.Requisites(this));

                Errors.Page = 9;
            }
            else
            {
                Main_Frame.Navigate(new Greeting());

                await Task.Delay(5000);

                Main_Frame.Navigate(new Screensaver());

                ThicknessAnimation MGanimationAuth = new()
                {
                    From = new Thickness(-70, 30, 0, 30),
                    To = new Thickness(20, 30, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Sidebar.BeginAnimation(MarginProperty, MGanimationAuth);

                Profile.ToolTip = Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname;

                Errors.Page = 0;
            }
        }
        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            var ta = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(0.8),
                DecelerationRatio = 0.7,
                To = new Thickness(0, 0, 0, 0)
            };
            if (e.NavigationMode == NavigationMode.New)
            {
                ta.From = new Thickness(500, 0, 0, 0);
            }
            else if (e.NavigationMode == NavigationMode.Back)
            {
                ta.From = new Thickness(0, 0, 500, 0);
            }
            ((Page)e.Content).BeginAnimation(MarginProperty, ta);
        }
        internal async void HideSideBar()
        {
            ThicknessAnimation MGanimationAuth = new()
            {
                From = new Thickness(20, 30, 0, 30),
                To = new Thickness(-70, 30, 0, 30),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Sidebar.BeginAnimation(MarginProperty, MGanimationAuth);

            ThicknessAnimation MGanimation = new()
            {
                From = new Thickness(0, 0, 0, 0),
                To = new Thickness(0, -50, 0, 0),
                Duration = new Duration(TimeSpan.FromSeconds(0.8))
            };
            Controls.BeginAnimation(MarginProperty, MGanimation);

            await Task.Delay(800);

            Animation = false;
        }
        internal async void ShowSideBar()
        {
            ThicknessAnimation MGanimationAuth = new()
                {
                    From = new Thickness(-70, 30, 0, 30),
                    To = new Thickness(20, 30, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
            Sidebar.BeginAnimation(MarginProperty, MGanimationAuth);
            
            ThicknessAnimation MGanimation = new()
                {
                    From = new Thickness(0, -50, 0, 0),
                    To = new Thickness(0, 0, 0, 0),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
            Controls.BeginAnimation(MarginProperty, MGanimation);

            await Task.Delay(800);

            Animation = false;
        }
    }
}
