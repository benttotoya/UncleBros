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
    public partial class StyleInheritanceCSharpPage : ContentPage
    {
        public StyleInheritanceCSharpPage()
        {
            InitializeComponent();

            var baseStyle = new Style(typeof(Xamarin.Forms.View))
            {
                Setters =
                {
                    new Setter { Property = Xamarin.Forms.View.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
                    new Setter { Property = Xamarin.Forms.View.MarginProperty, Value = 10},
                    new Setter { Property = BackgroundColorProperty, Value = Color.FromHex("#f0f") }
                }
            };

            var baseButtonStyle = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = Button.TextColorProperty, Value = Color.FromHex("#00a")},
                    new Setter { Property = BackgroundColorProperty, Value = Color.FromHex("#fc0")}
                }
            };

            var inheritLabel = new Style(typeof(Label))
            {
                BasedOn = baseStyle,
                Setters =
                {
                    new Setter { Property = Label.HorizontalTextAlignmentProperty, Value = LayoutOptions.Start},
                    new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.StartAndExpand},
                    new Setter { Property = Label.TextColorProperty, Value = Color.FromHex("#08f")}
                }
            };

            var inheritButton = new Style(typeof(Button))
            {
                BasedOn= baseStyle,
                Setters =
                {
                    new Setter { Property = Button.HorizontalOptionsProperty , Value = LayoutOptions.StartAndExpand},
                    new Setter { Property = Button.TextColorProperty, Value = Color.FromHex("#08f")}
                }
            };

            var mainButton = new Style(typeof(Button))
            {
                BasedOn = baseButtonStyle,
                Setters =
                {
                    new Setter { Property = Button.MarginProperty, Value = 30},
                    new Setter { Property = Button.PaddingProperty, Value = new Thickness(5, 5, 5, 5)}
                }
            };

            var mainStack = new StackLayout()
            {
                Children =
                {
                    new Label() { Text = "Inherited Views", Padding = 10 },
                    new Label() { Text = "Inherited Label Based On BaseStyle", Style = inheritLabel},
                    new Button() { Text = "Inherited Button Bsed On BaseStyle", Style=inheritButton},
                    new Button() { Text = "Inherited Button Based On baseButtonStyle", Style = mainButton }
                }
            };

            this.Content = mainStack;
        }
    }
}