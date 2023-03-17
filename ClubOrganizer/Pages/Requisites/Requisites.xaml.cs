using ClubOrganizer.Functions.Clear;
using ClubOrganizer.Pages.Requisites.Class;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ClubOrganizer.Pages.Requisites
{
    public partial class Requisites : Page
    {
        readonly Main main;
        bool first = true;
        bool Process = false;

        public Requisites(Main owner)
        {
            main = owner;
            InitializeComponent();

            Animation();
            this.VisualTextRenderingMode = TextRenderingMode.ClearType;
            DataCheck();
        }

        private void DigitText(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Lastname.Text.Trim() == "" && Username.Text.Trim() == "" &&
                Secondname.Text.Trim() == ""&& YrIndex.Text.Trim() == "" &&
                YrCity.Text.Trim() == "" && YrStreet.Text.Trim() == "" &&
                YrHouse.Text.Trim() == "" && YrFlat.Text.Trim() == "" &&
                FcIndex.Text.Trim() == "" && FcCity.Text.Trim() == "" &&
                FcStreet.Text.Trim() == "" && FcHouse.Text.Trim() == "" &&
                FcFlat.Text.Trim() == "" && Inn.Text.Trim() == "" && 
                Kpp.Text.Trim() == "" && Rass.Text.Trim() == "" && 
                Korr.Text.Trim() == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы не ввели данные";
                main.Error();
            }
            else if (Lastname.Text.Trim() == "" || Username.Text.Trim() == "" ||
                Secondname.Text.Trim() == "" || YrIndex.Text.Trim() == "" ||
                YrCity.Text.Trim() == "" || YrStreet.Text.Trim() == "" ||
                YrHouse.Text.Trim() == "" || YrFlat.Text.Trim() == "" ||
                FcIndex.Text.Trim() == "" || FcCity.Text.Trim() == "" ||
                FcStreet.Text.Trim() == "" || FcHouse.Text.Trim() == "" ||
                FcFlat.Text.Trim() == "" || Inn.Text.Trim() == "" || 
                Kpp.Text.Trim() == "" || Rass.Text.Trim() == "" || 
                Korr.Text.Trim() == "")
            {
                ClubOrganizer.Errors.AuthError = "Вы ввели не все данные";
                main.Error();
            }
            else
            {
                ClubOrganizer.Requisites.lastname = Lastname.Text.Trim();
                ClubOrganizer.Requisites.name= Username.Text.Trim();
                ClubOrganizer.Requisites.secondname = Secondname.Text.Trim();
                ClubOrganizer.Requisites.yr_index = YrIndex.Text.Trim();
                ClubOrganizer.Requisites.yr_city = YrCity.Text.Trim();
                ClubOrganizer.Requisites.yr_street = YrStreet.Text.Trim();
                ClubOrganizer.Requisites.yr_house = YrHouse.Text.Trim();
                ClubOrganizer.Requisites.yr_flat = YrFlat.Text.Trim();
                ClubOrganizer.Requisites.fc_index = FcIndex.Text.Trim();
                ClubOrganizer.Requisites.fc_city = FcCity.Text.Trim();
                ClubOrganizer.Requisites.fc_street = FcStreet.Text.Trim();
                ClubOrganizer.Requisites.fc_house = FcHouse.Text.Trim();
                ClubOrganizer.Requisites.fc_flat = FcFlat.Text.Trim();
                ClubOrganizer.Requisites.lastname = Lastname.Text.Trim();
                ClubOrganizer.Requisites.inn = Inn.Text.Trim();
                ClubOrganizer.Requisites.kpp = Kpp.Text.Trim();
                ClubOrganizer.Requisites.rass = Rass.Text.Trim();
                ClubOrganizer.Requisites.korr = Korr.Text.Trim();

                if (first == true)
                {
                    WriteReq.Write();
                    main.Enter();
                }
                else
                {
                    UpdReq.Update();
                }

                if (Process != true)
                {
                    Process = true;

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

                    Process = false;
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

        private void DataCheck()
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string db_path = doc + @"\Ладога\DB";

            FileInfo fileInfo = new(db_path + @"\requisites.db");
            if (fileInfo.Exists)
            {
                GetReq.Get();

                Lastname.Text = ClubOrganizer.Requisites.lastname;
                Username.Text = ClubOrganizer.Requisites.name;
                Secondname.Text = ClubOrganizer.Requisites.secondname;

                YrIndex.Text = ClubOrganizer.Requisites.yr_index;
                YrCity.Text = ClubOrganizer.Requisites.yr_city;
                YrStreet.Text = ClubOrganizer.Requisites.yr_street;
                YrHouse.Text = ClubOrganizer.Requisites.yr_house;
                YrFlat.Text = ClubOrganizer.Requisites.yr_flat;

                FcIndex.Text = ClubOrganizer.Requisites.fc_index;
                FcCity.Text = ClubOrganizer.Requisites.fc_city;
                FcStreet.Text = ClubOrganizer.Requisites.fc_street;
                FcHouse.Text = ClubOrganizer.Requisites.fc_house;
                FcFlat.Text = ClubOrganizer.Requisites.fc_flat;

                Inn.Text = ClubOrganizer.Requisites.inn;
                Kpp.Text = ClubOrganizer.Requisites.kpp;
                Rass.Text = ClubOrganizer.Requisites.rass;
                Korr.Text = ClubOrganizer.Requisites.korr;

                if (Lastname.Text == "" || Username.Text == "" || Secondname.Text == "")
                {
                    first = true;
                }
                else
                {
                    first = false;
                }
            }
        }
    }
}
