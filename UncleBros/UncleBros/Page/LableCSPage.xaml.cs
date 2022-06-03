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
    public partial class LableCSPage : ContentPage
    {
        public LableCSPage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.SlateBlue,
            };

            Label lable1 = new Label()
            {
                Text = "Lable1",
                Margin = 30,
                Padding = 10,
                BackgroundColor = Color.SeaShell,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                TextColor = Color.SlateBlue,
            };

            stackLayout.Children.Add(lable1);
            this.Content = stackLayout;
        }
    }
}