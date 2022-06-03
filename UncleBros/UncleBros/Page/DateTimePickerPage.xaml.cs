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
    public partial class DateTimePickerPage : ContentPage
    {
        public DateTimePickerPage()
        {
            InitializeComponent();
        }

        private void Date_Selected(object sender, DateChangedEventArgs e)
        {
            var id = (sender as DatePicker).Id;

            if (id == datePicker.Id)
            {
                char[] cDay = { '일', '월', '화', '수', '목', '금', '토' };
                lblDateTime.Text = datePicker.Date.ToString("yyyy-MM-dd");
                lblDateTime.Text += " " + cDay[(int)datePicker.Date.DayOfWeek] + "요일";
            }
        }

        private void Time_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var id = (sender as TimePicker).Id;
            if (e.PropertyName == "Time")
            {
                if (lblDateTime.Text.Length > 0)
                {
                    lblDateTime.Text += "\n";
                }

                DateTime dt = new DateTime(timePicker.Time.Ticks);
                lblDateTime.Text += dt.ToString("HH:mm:ss");
            }
        }
    }
}