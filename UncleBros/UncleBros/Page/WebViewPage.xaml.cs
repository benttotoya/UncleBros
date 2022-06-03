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
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            WebView webView = new WebView()
            {
                Source = "http://ems.bearplanet.co.kr/#!/",
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            /*
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(webView);
            this.Content = stackLayout;
            */
            this.Content = new StackLayout()
            {
                //Children이 list임
                Children =  
                {
                    webView
                }
            };
        }
    }
}