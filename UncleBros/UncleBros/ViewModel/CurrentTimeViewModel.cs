using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class CurrentTimeViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;

        public event PropertyChangedEventHandler PropertyChanged;

        public CurrentTimeViewModel()
        {
            this.DateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.DateTime = DateTime.Now;
                return true;
            });
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                if(dateTime != value)
                {
                    dateTime = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
        }
    }
}
