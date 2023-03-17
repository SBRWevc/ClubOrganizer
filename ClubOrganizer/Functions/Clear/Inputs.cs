using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace ClubOrganizer.Functions.Clear
{
    internal class Inputs
    {
        internal static void ClearInputs(DependencyObject obj)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                if (obj is TextBox box)
                {
                    box.Text = "";
                }
                if (obj is ComboBox combo)
                {
                    combo.Text = "";
                }

                ClearInputs(VisualTreeHelper.GetChild(obj, i));
            }
        }
    }
}
