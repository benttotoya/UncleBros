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
    public partial class DataBinding07 : ContentPage
    {
        StackLayout stackLayout = null;
        Label lblWelcome = null;
        Label lblLanguage = null;
        Slider slider1 = null;
        Slider slider2 = null;

        public DataBinding07()
        {
            InitializeComponent();
            InitUI();
            //InitDataBinding1();
            InitDataBinding2();
        }

        private void InitUI()
        {
            stackLayout = new StackLayout()
            {
                Padding = 20,
                BackgroundColor = Color.FromHex("#f88"),
            };

            lblWelcome = new Label()
            {
                Text = "Welcome to the hell.",
                BackgroundColor = Color.FromHex("#fff"),
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            lblLanguage = new Label()
            {
                Text = "XAMARIN",
                BackgroundColor = Color.FromHex("#fff"),
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            slider1 = new Slider()
            {
                Maximum = 100,
                Minimum = 10,
            };

            slider2 = new Slider()
            {
                Maximum = 100,
                Minimum = 10,
            };

            stackLayout.Children.Add(lblWelcome);
            stackLayout.Children.Add(lblLanguage);
            stackLayout.Children.Add(slider1);
            stackLayout.Children.Add(slider2);
            this.Content = stackLayout;
        }

        private void InitDataBinding1()
        {
            lblWelcome.BindingContext = slider1;
            lblLanguage.BindingContext = slider1;

            lblWelcome.SetBinding(Label.PaddingProperty, "Value");
            lblLanguage.SetBinding(Label.FontSizeProperty, "Value");
        }

        private void InitDataBinding2()
        {
            lblWelcome.SetBinding(Label.PaddingProperty, new Binding("Value", BindingMode.OneWay, null, null, null, slider1));
            lblLanguage.SetBinding(Label.FontSizeProperty, new Binding("Value", BindingMode.OneWay, null, null, null, slider1));

            slider1.SetBinding(Slider.ValueProperty, new Binding("Value", BindingMode.TwoWay, null, null, null, slider2));
        }
    }
}