using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTestApp.WeightLoss
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeightLossHome : ContentPage
    {
        public WeightLossHome()
        {
            InitializeComponent();
        }

        public void ExercisesButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Exercises.ExercisesPage());
        }
    }
}