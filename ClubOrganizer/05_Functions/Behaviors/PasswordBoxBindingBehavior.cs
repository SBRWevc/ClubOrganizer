using Microsoft.Xaml.Behaviors;


using System.Windows.Controls;
using System.Windows;

namespace ClubOrganizer._05_Functions.Behaviors
{
    public class PasswordBoxBindingBehavior : Behavior<PasswordBox>
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(
                "Password",
                typeof(string),
                typeof(PasswordBoxBindingBehavior),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnPasswordChanged));

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.PasswordChanged += OnPasswordBoxValueChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.PasswordChanged -= OnPasswordBoxValueChanged;
        }

        private void OnPasswordBoxValueChanged(object sender, RoutedEventArgs e)
        {
            Password = AssociatedObject.Password;
        }

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (PasswordBoxBindingBehavior)d;
            var passwordBox = behavior.AssociatedObject;
            if (passwordBox != null && passwordBox.Password != (string)e.NewValue)
            {
                passwordBox.Password = (string)e.NewValue;
            }
        }
    }
}
