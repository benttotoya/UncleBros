using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemListView : ContentView
    {
        public ItemListView()
        {
            pName.Text = "박동흠";
            pName.Padding = new Thickness(3, 3, 3, 3);
            InitializeComponent();
        }

        public string Name
        {
            get { return pName.Text; }
            set { pName.Text = value; }
        }
    }
}