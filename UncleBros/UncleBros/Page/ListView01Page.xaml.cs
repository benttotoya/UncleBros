using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView01Page : ContentPage
    {
        public ListView01Page()
        {
            InitializeComponent();

            /*
            this.Padding = 15;
            StackLayout stackLayout = new StackLayout();
            string[] items = new string[]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"
            };

            ListView listView = new ListView();
            listView.ItemsSource = items;

            stackLayout.Children.Add(listView);
            this.Content = stackLayout;
            */

            StackLayout stackLayout = new StackLayout();
            ListView listView = new ListView();
            listView.ItemsSource = new Color[]
            {
                Color.FromHex("#000"),
                Color.FromHex("#00f"),
                Color.FromHex("#0f0"),
                Color.FromHex("#0ff"),
                Color.FromHex("#f00"),
                Color.FromHex("#f0f"),
                Color.FromHex("#ff0"),
                Color.FromHex("#fff"),
            };

            stackLayout.SetBinding(StackLayout.BackgroundColorProperty, new Binding
            {
                Source = listView,
                Path = "SelectedItem",
                Mode = BindingMode.TwoWay
            });

            stackLayout.Children.Add(listView);
            this.Content = stackLayout;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Debug.WriteLine($"e.Item : {e.Item}");

            /*
            var stackLayout01 = (StackLayout)FindByName("stackLayout01");
            stackLayout01.Background = (Color)e.Item;
            */
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine($"e.SelectedItem : {e.SelectedItem}");
        }
    }
}