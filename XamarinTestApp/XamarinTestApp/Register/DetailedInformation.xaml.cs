using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.Register
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedInformation : ContentPage
    {
        public DetailedInformation()
        {
            InitializeComponent();
        }

        public void FinishRegistrationButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home.Home());
        }
    }
}