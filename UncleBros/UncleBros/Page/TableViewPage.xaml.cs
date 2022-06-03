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
    public partial class TableViewPage : ContentPage
    {
        bool bEnvironment = false;

        public TableViewPage()
        {
            InitializeComponent();
            

            SwitchCell sc = this.FindByName("Environ") as SwitchCell;
            if ((sc?.On).Equals(true))
            {
                bEnvironment = true;
            }
        }

        private void Environment_SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            
            var select = sender as SwitchCell;
            if (select.On == true)
            {
                bEnvironment = true;
                StackLayout stackLayout1 = new StackLayout()
                {
                    BackgroundColor = Color.White,
                    Padding = new Thickness(0, 0, 0, 0),
                    Orientation = StackOrientation.Vertical,
                };

                StackLayout stackLayout2 = new StackLayout()
                {
                    BackgroundColor = Color.White,
                    Padding = new Thickness(0, 0, 0, 0),
                    Orientation = StackOrientation.Vertical,
                };

                Label label1 = new Label()
                {
                    Text = "lbl1",
                    TextColor = Color.DarkViolet,
                    FontSize = 30,
                    Padding = new Thickness(10, 10, 10, 10),
                    BackgroundColor = Color.FromHex("ff00ff"),
                };

                Label label2 = new Label()
                {
                    Text = "lbl2",
                    TextColor = Color.DarkViolet,
                    FontSize = 30,
                    Padding = new Thickness(10, 10, 10, 10),
                    BackgroundColor = Color.FromHex("ffff00"),
                };

                stackLayout1.Children.Add(label1);
                stackLayout1.Children.Add(label2);
                stackLayout2.Children.Add(label2);

                /*
                this.Content = stackLayout1;
                this.Content = stackLayout2;
                */
            }
            else
            {
                bEnvironment = false;
            }
        }
    }
}