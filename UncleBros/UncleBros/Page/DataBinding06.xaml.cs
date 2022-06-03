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
    public partial class DataBinding06 : ContentPage
    {
        public DataBinding06()
        {
            InitializeComponent();
            //InitBinding1();
            //InitBinding2();
            InitBinding3();
        }

        private void InitBinding1()
        {
            lblWelcome.BindingContext = slider1;
            lblWelcome.SetBinding(Label.PaddingProperty, "Value");

            lblLanguage.BindingContext = slider1;
            lblLanguage.SetBinding(Label.FontSizeProperty, "Value");
        }

        private void InitBinding2()
        {
            Binding binding1 = new Binding()
            {
                Source = slider1,
                Path = "Value",
            };

            Binding binding2 = new Binding()
            {
                Source = slider1,
                Path = "Value",
            };

            lblWelcome.SetBinding(Label.PaddingProperty, binding1);
            lblLanguage.SetBinding(Label.FontSizeProperty, binding2);
        }

        private void InitBinding3()
        {
            lblWelcome.SetBinding(Label.PaddingProperty, new Binding("Value", BindingMode.OneWay, null, null, null, slider1));
            lblLanguage.SetBinding(Label.FontSizeProperty, new Binding("Value", BindingMode.OneWay, null, null, null, slider1));
        }
    }
}