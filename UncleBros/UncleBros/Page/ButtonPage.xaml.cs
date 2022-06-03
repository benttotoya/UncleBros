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
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();

            StackLayout sl = this.FindByName("Stack1") as StackLayout;
            Button button = new Button();
            button.Text = "버튼2";
            button.Clicked += btnClickMe2_Clicked;
            sl.Children.Add(button);
        }

        private void btnClickMe_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            button.IsEnabled = true;
        }

        private void btnClickMe2_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.IsEnabled = false;
            button.IsEnabled = true;
        }
    }
}