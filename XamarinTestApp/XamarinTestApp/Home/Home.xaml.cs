using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        public void WeightLossButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WeightLoss.WeightLossHome());
        }
    }
}