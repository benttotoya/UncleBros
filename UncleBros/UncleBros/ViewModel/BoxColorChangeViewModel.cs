using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace UncleBros.ViewModel
{
    public class BoxColorChangeViewModel : INotifyPropertyChanged
    {
        Color boxColor;
        double hue, saturation, luminosity, alpha;
        public event PropertyChangedEventHandler PropertyChanged;

        public BoxColorChangeViewModel()
        {
            BoxColor = Color.White;
        }

        public Color BoxColor
        {
            get
            {
                return boxColor;
            }
            set
            {
                if (boxColor != value)
                {
                    boxColor = value;
                    OnPropertyNotify("BoxColor");

                    // Box의 Color값이 외부에 의해 변경되면 각 요소도 변경됐다고 세팅
                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                    Alpha = value.A;
                }
            }
        }

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
                    OnPropertyNotify("Hue");
                    SetBoxColor();
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
                    OnPropertyNotify("Saturation");
                    SetBoxColor();
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
                    OnPropertyNotify("Luminosity");
                    SetBoxColor();
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
                    OnPropertyNotify("Alpha");
                    SetBoxColor();
                }
            }
        }

        protected void OnPropertyNotify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetBoxColor()
        {
            BoxColor = Color.FromHsla(Hue, Saturation, Luminosity, Alpha);
        }
        
    }
}
