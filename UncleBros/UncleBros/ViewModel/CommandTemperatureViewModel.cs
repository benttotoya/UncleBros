using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class CommandTemperatureViewModel : INotifyPropertyChanged
    {
        double dev01Temp, dev02Temp;
        Color labelColor1, labelColor2;

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand IncreaseCommandForDev01Temp { set; get; }
        public ICommand DecreaseCommandForDev01Temp { set; get; }
        public ICommand IncreaseCommandForDev02Temp { set; get; }
        public ICommand DecreaseCommandForDev02Temp { set; get; }

        public CommandTemperatureViewModel()
        {
            Dev01Temp = 30;
            Dev02Temp = 30;

            IncreaseCommandForDev01Temp = new Command(
                execute:() =>
                {
                    Dev01Temp += 1;
                },
                canExecute:() =>
                {
                    if (Dev01Temp >= 45)
                        return false;
                    else
                        return true;
                });

            DecreaseCommandForDev01Temp = new Command(
                execute:() =>
                {
                    Dev01Temp -= 1;
                },
                canExecute:() =>
                {
                    if (Dev01Temp <= 25)
                        return false;
                    else
                        return true;
                });

            IncreaseCommandForDev02Temp = new Command(
                execute: () =>
                {
                    Dev02Temp += 1;
                },
                canExecute: () =>
                {
                    if (Dev02Temp >= 45)
                        return false;
                    else
                        return true;
                });

            DecreaseCommandForDev02Temp = new Command(
                execute: () =>
                {
                    Dev02Temp -= 1;
                },
                canExecute: () =>
                {
                    if (Dev02Temp <= 25)
                        return false;
                    else
                        return true;
                });
        }

        public double Dev01Temp
        {
            get
            {
                return dev01Temp;
            }
            set
            {
                if (dev01Temp != value)
                {
                    dev01Temp = value;
                    OnPropertyChanged("Dev01Temp");
                    LabelColor1 = GetColorByTemperature(value);
                    ((Command)IncreaseCommandForDev01Temp)?.ChangeCanExecute();
                    ((Command)DecreaseCommandForDev01Temp)?.ChangeCanExecute();
                }
            }
        }

        public double Dev02Temp
        {
            get
            {
                return dev02Temp;
            }
            set
            {
                if (dev02Temp != value)
                {
                    dev02Temp = value;
                    OnPropertyChanged("Dev02Temp");
                    LabelColor2 = GetColorByTemperature(value);
                    ((Command)IncreaseCommandForDev02Temp)?.ChangeCanExecute();
                    ((Command)DecreaseCommandForDev02Temp)?.ChangeCanExecute();
                }
            }
        }

        public Color LabelColor1
        {
            get
            {
                return labelColor1;
            }
            set
            {
                if (labelColor1 != value)
                {
                    labelColor1 = value;
                    OnPropertyChanged("LabelColor1");
                }
                
            }
        }

        public Color LabelColor2
        {
            get
            {
                return labelColor2;
            }
            set
            {
                if (labelColor2 != value)
                {
                    labelColor2 = value;
                }
                OnPropertyChanged("LabelColor2");
            }
        }

        private Color GetColorByTemperature(double temperature)
        {
            if (temperature > 40)
            {
                return Color.Red;
            }
            else if (temperature > 30)
            {
                return Color.Green;
            }
            else
            {
                return Color.Blue;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
