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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }

        private void gradePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItemLabel.Text = "Item [" + (sender as Picker).SelectedItem.ToString() + "] selected!!!";
        }
    }
}