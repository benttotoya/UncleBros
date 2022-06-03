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
    public partial class MVVM_DateTime02 : ContentPage
    {
        public MVVM_DateTime02()
        {
            InitializeComponent();
            Device.StartTimer(new TimeSpan(0, 0, 1), timer);
        }

        private bool timer()
        {
            lbl01.Text = $"{DateTime.Now}";
            lbl02.Text = $"The Year is {DateTime.Now.Year}";
            lbl03.Text = $"The Month is {DateTime.Now.Month}";
            lbl04.Text = $"The Day is {DateTime.Now.Day}";
            lbl05.Text = $"The Time is {DateTime.Now.TimeOfDay}";

            return true;
        }
    }
}