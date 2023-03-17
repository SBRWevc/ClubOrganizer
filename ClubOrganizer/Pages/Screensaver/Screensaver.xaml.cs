using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ClubOrganizer.Pages.Screensaver
{
    public partial class Screensaver : Page
    {
        public Screensaver()
        {
            InitializeComponent();

            PRF_fullname.Text = Userdata.Lastname + " " +
                Userdata.Name + " " + Userdata.Secondname;
            PRF_position.Text = Userdata.Position;

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
    }
}
