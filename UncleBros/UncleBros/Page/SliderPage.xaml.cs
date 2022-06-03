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
    public partial class SliderPage : ContentPage
    {
        public SliderPage()
        {
            InitializeComponent();

            Slider slider = new Slider()
            {

            };
            Convert.ToDouble(entrySlider01.Text);
        }

        private void Slider01_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var id = (sender as Slider).Id;
            if (id == Slider01.Id)
            {
                entrySlider01.Text = String.Format($"Slider01.Value : {Slider01.Value}");
            }
        }
    }
}