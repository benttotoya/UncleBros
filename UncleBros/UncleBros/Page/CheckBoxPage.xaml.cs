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
    public partial class CheckBoxPage : ContentPage
    {
        public CheckBoxPage()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var id = (sender as CheckBox).Id;
            string strSelectedMenu = string.Empty;

            if (ckbHamburger.IsChecked)
            {
                strSelectedMenu += lblHamburger.Text + "\n";
            }

            if (ckbFrenchfries.IsChecked)
            {
                strSelectedMenu += lblFrenchfries.Text + "\n";
            }

            if (ckbDrink.IsChecked)
            {
                strSelectedMenu += lblDrink.Text + "\n";
            }

            if (strSelectedMenu.Length > 1)
            {
                strSelectedMenu = strSelectedMenu.Remove(strSelectedMenu.Length - 1, 1);
            }

            editSelectedMenu.Text = strSelectedMenu;
            lblSelectedMenu.Text = strSelectedMenu;
        }
    }
}