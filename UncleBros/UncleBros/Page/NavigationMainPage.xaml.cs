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
    public partial class NavigationMainPage : ContentPage
    {
        public NavigationMainPage()
        {
            InitializeComponent();
        }

        private async void btnPageMove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationSecondPage());
        }
    }
}