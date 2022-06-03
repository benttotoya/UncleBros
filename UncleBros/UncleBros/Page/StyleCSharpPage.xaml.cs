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
    public partial class StyleCSharpPage : ContentPage
    {
        public StyleCSharpPage()
        {
            InitializeComponent();

            var mainTitleStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter() { Property = Label.TextColorProperty, Value = Color.White },
                    new Setter() { Property = Label.FontSizeProperty, Value = 30 },
                    new Setter() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold},
                    new Setter() { Property = Label.BackgroundColorProperty, Value = Color.FromHex("#f00") },
                    new Setter() { Property = Label.PaddingProperty, Value = new Thickness(5, 5, 5, 5)},
                    new Setter() { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Start}
                }
            };

            var subTitleStyle = new Style(typeof(Label))
            {
                Setters = 
                {
                    new Setter() { Property = Label.TextColorProperty, Value = Color.White},
                    new Setter() { Property = Label.FontSizeProperty, Value = 25},
                    new Setter() { Property = Label.FontAttributesProperty, Value = FontAttributes.Bold},
                    new Setter() { Property = Label.BackgroundColorProperty, Value = Color.FromHex("#800")},
                    new Setter() { Property = Label.PaddingProperty, Value = new Thickness(10, 5, 5, 5)},
                    new Setter() { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Start}
                }
            };

            var contentsStyle = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter() { Property = Label.TextColorProperty, Value = Color.White},
                    new Setter() { Property = Label.FontSizeProperty, Value = 15},
                    new Setter() { Property = Label.FontAttributesProperty, Value = FontAttributes.Italic},
                    new Setter() { Property = Label.BackgroundColorProperty, Value = Color.FromHex("#500")},
                    new Setter() { Property = Label.PaddingProperty, Value = new Thickness(20, 5, 5, 5)},
                    new Setter() { Property = Label.HorizontalTextAlignmentProperty, Value = TextAlignment.Start}
                }
            };

            var buttonStyle = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter() { Property = Button.TextColorProperty, Value = Color.FromHex("#000")},
                    new Setter() { Property = Button.FontSizeProperty, Value = 15},
                    new Setter() { Property = Button.FontAttributesProperty, Value = FontAttributes.Bold},
                    new Setter() { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#0ff")},
                    new Setter() { Property = Button.PaddingProperty, Value = 10},
                    new Setter() { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.StartAndExpand}
                }
            };


            StackLayout mainstackLayout = new StackLayout()
            {
                Padding = 10
            };

            StackLayout substackLayout1 = new StackLayout()
            {
                Padding = new Thickness(0, 0, 0, 10)
            };

            StackLayout substackLayout2 = new StackLayout()
            {
                Padding = new Thickness(0, 0, 0, 10)
            };

            // article1
            Label mainTitleLable1 = new Label
            {
                Text = "Main Title",
                Style = mainTitleStyle
            };

            Label subTitleLable1 = new Label
            {
                Text = "Sub Title",
                Style = subTitleStyle
            };

            Label contentsLable1 = new Label
            {
                Text = "자마린(Xamarin)은 2011년 5월, Mono, MonoTouch, Mono fo Android 개발자인 미구엘 더 이카사에 의해 설립된 기업이다.",
                Style = contentsStyle
            };

            Button moreButton1 = new Button
            {
                Text = "More",
                Style = buttonStyle
            };


            // article2
            Label subTitleLable2 = new Label
            {
                Text = "Sub Title",
                Style = subTitleStyle
            };

            Label contentsLable2 = new Label
            {
                Text = "이러한 3개의 소프트웨어는 공통 언어 기반으로 크로스 플랫폼을 구현하기 위해 만들어졌다",
                Style = contentsStyle
            };

            Button moreButton2 = new Button
            {
                Text = "More",
                Style = buttonStyle
            };

            // article1
            substackLayout1.Children.Add(mainTitleLable1);
            substackLayout1.Children.Add(subTitleLable1);
            substackLayout1.Children.Add(contentsLable1);
            substackLayout1.Children.Add(moreButton1);

            // article2
            substackLayout2.Children.Add(mainTitleLable1);
            substackLayout2.Children.Add(subTitleLable2);
            substackLayout2.Children.Add(contentsLable2);
            substackLayout2.Children.Add(moreButton2);

            mainstackLayout.Children.Add(substackLayout1);
            mainstackLayout.Children.Add(substackLayout2);
            this.Content = mainstackLayout;
        }
    }
}