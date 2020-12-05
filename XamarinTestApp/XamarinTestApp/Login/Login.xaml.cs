using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        // TODO check if user is authorized
        public void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home.Home());
        }

        public void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register.Register());
        }
    }
}