using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class CommandTemperature2ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int temperature;
        Color temperatureColor;

        public ICommand DecreaseTemperatureCommand { get; set; }
        public ICommand IncreaseTemperatureCommand { get; set; }

        public CommandTemperature2ViewModel()
        {
            Temperature = 30;
            DecreaseTemperatureCommand = new Command(
                execute:() =>
                {
                    Temperature -= 1;
                },
                canExecute:() =>
                {
                    if (Temperature <= 25)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                });
            IncreaseTemperatureCommand = new Command(
                execute: () =>
                {
                    Temperature += 1;
                },
                canExecute: () =>
                {
                    if (Temperature >= 45)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                });
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (temperature != value)
                {
                    temperature = value;
                    OnTemperatureChanged("Temperature");
                    TemperatureColor = GetColorByTemperature(value);
                    ((Command)DecreaseTemperatureCommand)?.ChangeCanExecute();
                    ((Command)IncreaseTemperatureCommand)?.ChangeCanExecute();
                }
            }
        }

        public Color TemperatureColor
        {
            get
            {
                return temperatureColor;
            }
            set
            {
                if (temperatureColor != null)
                {
                    temperatureColor = value;
                    OnTemperatureChanged("TemperatureColor");
                }
            }
        }

        private Color GetColorByTemperature(int temperature)
        {
            if (temperature > 40)
                return Color.Red;
            else if (temperature > 30)
                return Color.Green;
            else
                return Color.Blue;
        }

        private void OnTemperatureChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
