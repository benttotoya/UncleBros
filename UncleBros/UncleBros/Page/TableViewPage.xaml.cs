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
        public TableViewPage()
        {
            InitializeComponent();
        }

        private void Environment_SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            var select = sender as SwitchCell;
            if (select.On == true)
            {

            }
        }
    }
}