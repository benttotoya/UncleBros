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
    public partial class Picker2Page : ContentPage
    {
        public Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            {"Aqua", Color.Aqua }, 
            {"Black", Color.Black },
            {"Chocolate", Color.Chocolate },
            {"DeepSkyBlue", Color.DeepSkyBlue },
            {"Firebrick", Color.Firebrick },
            {"Green", Color.Green },
            {"HotPink", Color.HotPink },
            {"Ivory", Color.Ivory },
            {"Khaki", Color.Khaki },
            {"Lavender", Color.Lavender },
            {"Maroon", Color.Maroon },
            {"Navy", Color.Navy },
            {"Orange", Color.Orange },
            {"Plum", Color.Plum },
            {"Red", Color.Red },
            {"Salmon", Color.Salmon },
            {"Tomato", Color.Tomato },
            {"Violet", Color.Violet },
            {"White", Color.White },
            {"Yellow", Color.Yellow }
        };

        public Picker2Page()
        {
            InitializeComponent();
            this.Padding = 15;

            StackLayout mainStackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.FromHex("#ccc"),
            };

            StackLayout sub1StackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.FromHex("#aaa"),
            };

            Label label1 = new Label
            {
                Text = "Select Color",
                FontSize = 15,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };

            Picker colorPicker = new Picker
            {
                Title = "Color",
                TitleColor = Color.White,
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold,
                ItemsSource = nameToColor?.Keys.ToArray(),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                WidthRequest = 100,
                Margin = new Thickness(0, 0, 10, 0),
            };

            Label label2 = new Label
            {
                Text = "",
                FontSize = 15,
                TextColor = Color.Black,
                Background = Color.White,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
            };

            BoxView boxBiew = new BoxView
            {
                WidthRequest = 100,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            StackLayout sub2StackLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.FromHex("#555"),
            };

            colorPicker.SelectedIndexChanged += (sender, eventArgs) =>
            {
                string colorName = (sender as Picker).SelectedItem.ToString();
                nameToColor.TryGetValue(colorName, out Color value);

                //label2.Text = colorName;
                //sub2StackLayout.BackgroundColor = value;
                boxBiew.BackgroundColor = value;
            };

            sub1StackLayout.Children.Add(label1);
            sub1StackLayout.Children.Add(colorPicker);

            //sub2StackLayout.Children.Add(label2);
            sub2StackLayout.Children.Add(boxBiew);

            mainStackLayout.Children.Add(sub1StackLayout);
            mainStackLayout.Children.Add(sub2StackLayout);
            this.Content = mainStackLayout;
        }
    }
}