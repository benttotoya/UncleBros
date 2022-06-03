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
    public partial class DynamicStylePage : ContentPage
    {
        bool originStyle = true;

        public DynamicStylePage()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (originStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originStyle = true;
            }
        }
    }
}