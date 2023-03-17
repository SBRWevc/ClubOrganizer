using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClubOrganizer.Pages.Fast_Rent
{
    public partial class Fast_Rent : Page
    {
        public Fast_Rent()
        {
            InitializeComponent();
            Animation();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
