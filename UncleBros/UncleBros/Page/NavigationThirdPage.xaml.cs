using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationThirdPage : ContentPage
    {
        public NavigationThirdPage()
        {
            InitializeComponent();
        }

        private async void btnPageMove_Clicked(object sender, EventArgs e)
        {
            var id = (sender as Button).Id;

            if (id == btnMainPage.Id)
            {
                await Navigation.PopToRootAsync();
            }

            if (id == btnSecondPage.Id)
            {
                await Navigation.PopAsync(IsEnabled);
            }
        }
    }
}