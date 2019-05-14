using System;
using Xamarin.Forms;

namespace BootcampStoreForms.Pages
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var label = new Label
            {
                Text = "Login",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            var username = new Entry()
            {

            };

            var password = new Entry()
            {

            };

            var loginButton = new Button()
            {

            };

            var mainStack = new StackLayout
            {
                Padding = 30,
                VerticalOptions = LayoutOptions.Center
            };

            mainStack.Children.Add(label);
            mainStack.Children.Add(username);
            mainStack.Children.Add(password);
            mainStack.Children.Add(loginButton);

            Content = mainStack;
        }
    }
}