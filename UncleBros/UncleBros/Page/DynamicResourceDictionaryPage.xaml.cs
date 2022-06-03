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
    public partial class DynamicResourceDictionaryPage : ContentPage
    {
        public DynamicResourceDictionaryPage()
        {
            InitializeComponent();
        }

        private void OnButton_Clicked(object sender, EventArgs e)
        {
            var id = (sender as Button).Id;

            if (id == btnBGColorRed.Id)
            {
                lblTopLabel.BackgroundColor = (Color)Application.Current.Resources["AppColorRed"];
            }
            else if (id == btnBGColorGreen.Id)
            {
                lblTopLabel.BackgroundColor = (Color)Application.Current.Resources["AppColorGreen"];
            }
            else if (id == btnBGColorBlue.Id)
            {
                lblTopLabel.BackgroundColor = (Color)Application.Current.Resources["AppColorBlue"];
            }
            else if (id == btnPaddingBig.Id)
            {
                lblTopLabel.Padding = (Double)this.Resources["DRPadding30"];
            }
            else if (id == btnPaddingMiddle.Id)
            {
                lblTopLabel.Padding = (Thickness)Application.Current.Resources["AppPadding20"];
            }
            else if (id == btnPaddingSmall.Id)
            {
                lblTopLabel.Padding = (Thickness)Application.Current.Resources["AppPadding10"];
            }
            else if (id == btnFontSizeBig.Id)
            {
                lblTopLabel.FontSize = (Double)Application.Current.Resources["AppFontSize30"];
            }
            else if (id == btnFontSizeMiddle.Id)
            {
                lblTopLabel.FontSize = (Double)Application.Current.Resources["AppFontSize20"];
            }
            else if (id == btnFontSizeSmall.Id)
            {
                lblTopLabel.FontSize = (Double)Application.Current.Resources["AppFontSize10"];
            }
        }
    }
}