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
    public partial class DataBinding01 : ContentPage
    {
        public DataBinding01()
        {
            InitializeComponent();
            InitProperty();
        }

        private void Event_SliderDragCompleted(object sender, EventArgs e)
        {
            var id = (sender as Slider).Id;

            if (id == slider1.Id)
            {
                lblWelcome.Padding = (int)slider1.Value;
                lblLanguage.FontSize = (int)slider1.Value;
            }
        }

        private void Event_SliderDragChanged(object sender, ValueChangedEventArgs e)
        {
            var id = (sender as Slider).Id;

            if (id == slider1.Id)
            {
                lblWelcome.Padding = (int)slider1.Value;
                lblLanguage.FontSize = (int)slider1.Value;
            }
        }

        private void InitProperty()
        {
            lblWelcome.Padding = (int)slider1.Value;
            lblLanguage.FontSize = (int)slider1.Value;
        }
    }
}