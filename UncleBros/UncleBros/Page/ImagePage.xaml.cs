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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout()
            {
                BackgroundColor = Color.FromHex("ffff00")
            };

            Image image1 = new Image()
            {
                BackgroundColor = Color.FromHex("ff0000"),
                Source = ImageSource.FromUri(new Uri("https://search.pstatic.net/sunny/?src=https%3A%2F%2Fimage.utoimage.com%2Fpreview%2Fcp867227%2F2017%2F08%2F201708014878_800.jpg")),
            };

            stackLayout.Children.Add(image1);
            this.Content = stackLayout;
        }
    }
}