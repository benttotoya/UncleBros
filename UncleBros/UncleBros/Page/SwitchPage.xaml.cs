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
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void SwitchToggled(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var id = (sender as Switch).Id;
            string strSelectMenu = string.Empty;

            if (swtHamburger.IsToggled)
            {
                strSelectMenu += lblHamburger.Text + "\n";
            }

            if (swtFrenchfries.IsToggled)
            {
                strSelectMenu += lblFrenchfries.Text + "\n";
            }

            if (swtDrink.IsToggled)
            {
                strSelectMenu += lblDrink.Text + "\n";
            }

            if (strSelectMenu.Length > 1 && strSelectMenu.Substring(strSelectMenu.Length - 1, 1).Equals("\n"))
            {
                strSelectMenu = strSelectMenu.Remove(strSelectMenu.Length - 1, 1);
            }

            lblSelectedMenu.Text = strSelectMenu;
        }
    }
}