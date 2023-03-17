using ClubOrganizer.Functions.Clear;
using ClubOrganizer.Pages.Fast_Tennis.Class;
using ClubOrganizer.Pages.Fast_Tennis.Class.Client;
using ClubOrganizer.Pages.Fast_Tennis.Class.Contracts;
using ClubOrganizer.Pages.Fast_Tennis.Class.Docx;
using ClubOrganizer.Pages.Fast_Tennis.Class.Service;
using ClubOrganizer.Pages.Requisites.Class;
using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.Fast_Tennis
{
    public partial class Fast_Tennis : Page
    {
        readonly Main main;
        bool open = false;
        public Fast_Tennis(Main owner)
        {
            main = owner;

            InitializeComponent();
        }

        private async void Animation()
        {
            if (open == false)
            {
                await Task.Delay(800);
                ThicknessAnimation MGanimation = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.5))
                };
                Bottombar.BeginAnimation(MarginProperty, MGanimation);
                open = true;
            }            
        }

        private void DigitalTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ContractMoney.Check();
            InsContract.Insert();
            InsDtService.Insert();
            ServiceDocx.Footer();
            Open_Docx();
            Clear();
        }

        private void Client_Save_Click(object sender, RoutedEventArgs e)
        {
            if (Lastname.Text == "" && Username.Text == "" && Secondname.Text == "" && Phone.Text == "")
            {
                Errors.AuthError = "Вы не ввели данные";
                main.Error();
            }
            else if (Lastname.Text == "" || Username.Text == "" || Secondname.Text == "" || Phone.Text == "")
            {
                Errors.AuthError = "Вы ввели не все данные";
                main.Error();
            }
            else
            {
                NewClient.Lastname = Lastname.Text.Trim();
                NewClient.Username = Username.Text.Trim();
                NewClient.Secondname = Secondname.Text.Trim();
                NewClient.Phone = Phone.Text.Trim();
                NewClient.Fullname = Lastname.Text + " " +
                    Username.Text[..(Username.Text.Length -
                    Username.Text.Length + 1)] + "." +
                    Secondname.Text[..(Secondname.Text.Length -
                    Secondname.Text.Length + 1)] + ".";
                NewClient.Registration = DateTime.Now.ToString("dd/MM/yy");
                NewClient.Admin = Userdata.Lastname + " " + Userdata.Name + " " + Userdata.Secondname;
                NewClient.Black = "нет";

                ChClient.Check();

                ServiceData.IsEnabled = true;
                Day_save.IsEnabled = true;
                Cancel_save.IsEnabled = true;

                Lastname.IsEnabled = false;
                Username.IsEnabled = false;
                Secondname.IsEnabled = false;
                Phone.IsEnabled = false;

                if (Main.Animation != true)
                {
                    Main.Animation = true;

                    main.HideSideBar();
                }
            }
        }

        private void Day_save_Click(object sender, RoutedEventArgs e)
        {
            int year = DateTime.Now.Year;
            var EndOfYear = new DateTime(year, 12, 31);
            var EndPeriod = Day_End.DisplayDate;

            if (Day.Text == "" && Price.Text == "" && Day_Start.Text == "" &&
                Day_End.Text == "" && HourST.Text == "" && MinST.Text == "" &&
                HourED.Text == "" && MinED.Text == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не ввели дынные";
                main.Error();
            }
            else if (Day.Text == "" || Price.Text == "" || Day_Start.Text == "" ||
                Day_End.Text == "" || HourST.Text == "" || MinST.Text == "" ||
                HourED.Text == "" || MinED.Text == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы ввели не все данные";
                main.Error();
            }
            else if (EndPeriod > EndOfYear)
            {
                ClubOrganizer.Errors.AuthError = "Превышен максимальный срок договора";
                main.Error();
            }
            else if (Convert.ToInt32(HourST.Text) > Convert.ToInt32(HourED.Text))
            {
                ClubOrganizer.Errors.AuthError = "Проверьте время";
                main.Error();
            }
            else
            {
                ContractData.DateStart = Day_Start.SelectedDate.Value;
                ContractData.DateEnd = Day_End.SelectedDate.Value;

                ContractData.HourST = Convert.ToDouble(HourST.Text); 
                ContractData.MinST = Convert.ToDouble(MinST.Text);
                ContractData.HourED = Convert.ToDouble(HourED.Text);
                ContractData.MinED = Convert.ToDouble(MinED.Text);

                ContractData.tstart = HourST.Text + ":" + MinST.Text;
                ContractData.tend = HourED.Text + ":" + MinED.Text;

                ClubOrganizer.ServiceData.start = HourST.Text + ":" + MinST.Text;
                ClubOrganizer.ServiceData.end = HourED.Text + ":" + MinED.Text;

                ContractData.price = Price.Text.Trim();

                DaysHours.HoursSum();

                if (Day.Text == "Понедельник")
                {
                    ContractData.DayOfWeek = DayOfWeek.Monday;
                }
                if (Day.Text == "Вторник")
                {
                    ContractData.DayOfWeek = DayOfWeek.Tuesday;
                }
                if (Day.Text == "Среда")
                {
                    ContractData.DayOfWeek = DayOfWeek.Wednesday;
                }
                if (Day.Text == "Четверг")
                {
                    ContractData.DayOfWeek = DayOfWeek.Thursday;
                }
                if (Day.Text == "Пятница")
                {
                    ContractData.DayOfWeek = DayOfWeek.Friday;
                }
                if (Day.Text == "Суббота")
                {
                    ContractData.DayOfWeek = DayOfWeek.Saturday;
                }
                if (Day.Text == "Воскресенье")
                {
                    ContractData.DayOfWeek = DayOfWeek.Sunday;
                }

                DaysHours.DaysSum();
                DaysHours.MonthSum();

                CrtService.Create();

                Update();

                Animation();
            }
        }

        private void Lastname_GotFocus(object sender, RoutedEventArgs e)
        {
            NewClient.lt_clients_last = new();
            GetClients.GetLast();
            Lastname.ItemsSource = NewClient.lt_clients_last.AsDataView();
            Lastname.DisplayMemberPath = "Фамилия";
        }

        private void Username_GotFocus(object sender, RoutedEventArgs e)
        {
            NewClient.Lastname = Lastname.Text.Trim();

            NewClient.lt_clients_user = new();
            GetClients.GetUser();
            Username.ItemsSource = NewClient.lt_clients_user.AsDataView();
            Username.DisplayMemberPath = "Имя";
        }

        private void Secondname_GotFocus(object sender, RoutedEventArgs e)
        {
            NewClient.Lastname = Lastname.Text.Trim();
            NewClient.Username = Username.Text.Trim();

            NewClient.lt_clients_sec = new();
            GetClients.GetSec();
            Secondname.ItemsSource = NewClient.lt_clients_sec.AsDataView();
            Secondname.DisplayMemberPath = "Отчество";
        }

        private void Phone_GotFocus(object sender, RoutedEventArgs e)
        {
            NewClient.Lastname = Lastname.Text.Trim();
            NewClient.Username = Username.Text.Trim();
            NewClient.Secondname = Secondname.Text.Trim();

            NewClient.lt_clients_phon = new();
            GetClients.GetPhon();
            Phone.ItemsSource = NewClient.lt_clients_phon.AsDataView();
            Phone.DisplayMemberPath = "Телефон";
        }

        private void Update()
        {
            ClubOrganizer.ServiceData.dt_clients = new();
            GetServices.Get();
            Data_services.ItemsSource = ClubOrganizer.ServiceData.dt_clients.AsDataView();
        }

        private void Lastname_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Lastname.Text == "")
            {
                Username.IsEnabled = false;
                Username.Text = "";
                Secondname.IsEnabled = false;
                Secondname.Text = "";
                Phone.IsEnabled = false;
                Phone.Text = "";
            }
            else
            {
                Username.IsEnabled = true;
            }
        }

        private void Username_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Username.Text == "")
            {
                Secondname.IsEnabled = false;
                Secondname.Text = "";
                Phone.IsEnabled = false;
                Phone.Text = "";
            }
            else
            {
                Secondname.IsEnabled = true;
            }
        }

        private void Secondname_MouseLeave(object sender, MouseEventArgs e)
        {
            if (Secondname.Text == "")
            {
                Phone.IsEnabled = false;
                Phone.Text = "";
            }
            else
            {
                Phone.IsEnabled = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetReq.Get();
        }

        private void Cancel_save_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            ClearData.Clear();
        }

        private async void Clear()
        {
            Inputs.ClearInputs(this);

            Lastname.IsEnabled = true;
            Username.IsEnabled = false;
            Secondname.IsEnabled = false;
            Phone.IsEnabled = false;

            Data_services.ItemsSource = null;
            Day_save.IsEnabled = false;
            Cancel_save.IsEnabled = false;

            ClubOrganizer.ServiceData.dt_clients.Clear();

            ServiceData.IsEnabled = false;

            if (Main.Animation != true)
            {
                Main.Animation = true;

                main.ShowSideBar();
            }

            Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.DeleteOutline;
            Icon.Foreground = Brushes.Black;

            Thickness BottombarMG = new(108, 0, 0, 30);

            if (Bottombar.Margin == BottombarMG)
            {
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

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
            }
            else
            {
                ThicknessAnimation MGanimationSuc = new()
                {
                    From = new Thickness(108, 0, 0, -70),
                    To = new Thickness(108, 0, 0, 30),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSuc);

                await Task.Delay(4500);

                ThicknessAnimation MGanimationSucBack = new()
                {
                    From = new Thickness(108, 0, 0, 30),
                    To = new Thickness(108, 0, 0, -70),
                    Duration = new Duration(TimeSpan.FromSeconds(0.8))
                };
                Succes.BeginAnimation(MarginProperty, MGanimationSucBack);
            }            

            open = false;
        }

        private static void Open_Docx()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path_contract = doc + @"\Ладога\Docx\Договоры\" + NewClient.Lastname + "_" + NewClient.Username + "_" + NewClient.Secondname + @"\";

            ProcessStartInfo procs_contract = new()
            {
                WorkingDirectory = path_contract,
                FileName = Convert.ToString(NewClient.id_ctr) + @" - " + DateTime.Now.Year.ToString() + @".docx",
                UseShellExecute = true
            };
            Process.Start(procs_contract);

            string path_service = doc + @"\Ладога\Docx\Счета\" + Convert.ToString(NewClient.id_ctr) + " - " + DateTime.Now.Year.ToString() + @"\";

            ProcessStartInfo procs_service = new()
            {
                WorkingDirectory = path_service,
                FileName = ClubOrganizer.ServiceData.id + @".docx",
                UseShellExecute = true
            };
            Process.Start(procs_service);
        }
    }
}
