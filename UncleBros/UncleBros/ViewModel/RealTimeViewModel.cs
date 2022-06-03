using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class RealTimeViewModel : INotifyPropertyChanged
    {
        DateTime dateTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public RealTimeViewModel()
        {
            DateTimeProperty = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                DateTimeProperty = DateTime.Now;
                return true;
            });
        }

        public DateTime DateTimeProperty
        {
            get
            {
                return dateTime;
            }
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTimeProperty"));
                    }
                }
            }
        }

    }
}
