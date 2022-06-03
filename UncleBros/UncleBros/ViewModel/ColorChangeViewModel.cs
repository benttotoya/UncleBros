using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class ColorChangeViewModel : INotifyPropertyChanged
    {
        double hue, saturation, luminosity, alpha;
        Color currentColor;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Hue
        {
            get
            {
                return hue;
            }
            set
            {
                if (hue != value)
                {
                    hue = value;
                    OnPropertyChanged("Hue");
                    SetColor();
                }
            }
        }

        public double Saturation
        {
            get
            {
                return saturation;
            }
            set
            {
                if (saturation != value)
                {
                    saturation = value;
                    OnPropertyChanged("Saturation");
                    SetColor();
                }
            }
        }

        public double Luminosity
        {
            get
            {
                return luminosity;
            }
            set
            {
                if (luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged("Luminosity");
                    SetColor();
                }
            }
        }

        public double Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (alpha != value)
                {
                    alpha = value;
                    OnPropertyChanged("Alpha");
                    SetColor();
                }
            }
        }

        public Color CurrentColor
        {
            get
            {
                return currentColor;
            }
            set
            {
                if (currentColor != value)
                {
                    currentColor = value;
                    OnPropertyChanged("CurrentColor");

                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                    Alpha = value.A;
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetColor()
        {
            CurrentColor = Color.FromHsla(Hue, Saturation, Luminosity, Alpha);
        }
    }
}
