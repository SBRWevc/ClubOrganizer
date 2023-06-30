using ClubOrganizer._03_View.Pages.Configuration;

using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace ClubOrganizer._05_Functions.Converters
{
    public class PageToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var currentPage = (Page)value;

            if(currentPage is PageWelcome)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
