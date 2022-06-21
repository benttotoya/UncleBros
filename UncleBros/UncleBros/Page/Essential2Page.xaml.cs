using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Essential2Page : ContentPage
    {
        Label lblX;
        Label lblY;
        Label lblZ;
        Button btnStart;
        Button btnStop;

        Entry entryLocationName;
        Entry entryLatitude;
        Entry entryLongitude;
        Button btnGeoCoding;
        Button btnReverseGeoCoding;
        Label lblLocationInfo;

        Button btnGeoLocation;
        Label lblGeoLocation;

        public Essential2Page()
        {
            InitializeComponent();

            ScrollView scrollView = new ScrollView();
            StackLayout stackLayout = new StackLayout();
            stackLayout.Padding = 20;

            StackLayout stackLayout1 = new StackLayout();
            StackLayout stackLayout2 = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
            };

            StackLayout stackLayout3 = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
            };

            /// Accelerometer
            /// 

            lblX = new Label();
            lblY = new Label();
            lblZ = new Label();
            btnStart = new Button
            {
                Text = "Start",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
            };
            btnStart.Clicked += OnBtnStart_Clicked;

            btnStop = new Button
            {
                Text = "Stop",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
            };
            btnStop.Clicked += OnBtnStop_Clicked;

            /// GeoCoding/ReverseGeoCoding
            /// 

            entryLocationName = new Entry
            {
                Placeholder = "Enter Address or Location Name"   
            };

            entryLatitude = new Entry
            {
                Placeholder = "Latitude",
            };

            entryLongitude = new Entry
            {
                Placeholder = "Longitude",
            };

            btnGeoCoding = new Button
            {
                Text = "GeoCoding",
            };
            btnGeoCoding.Clicked += OnBtnGeoCoding_Clicked;

            btnReverseGeoCoding = new Button
            {
                Text = "ReverseGeoCoding",
            };
            btnReverseGeoCoding.Clicked += OnBtnReverseGeoCoding_Clicked;

            lblLocationInfo = new Label
            {
                Text = "LocationInfo"
            };

            /// Geolocaion
            /// 
            btnGeoLocation = new Button
            {
                Text = "GeoLocation",
            };
            btnGeoLocation.Clicked += OnBtnGeoLocation_Clicked;

            lblGeoLocation = new Label
            {

            };

            stackLayout1.Children.Add(lblX);
            stackLayout1.Children.Add(lblY);
            stackLayout1.Children.Add(lblZ);
            stackLayout1.Children.Add(btnStart);
            stackLayout1.Children.Add(btnStop);

            stackLayout2.Children.Add(entryLocationName);
            stackLayout2.Children.Add(entryLatitude);
            stackLayout2.Children.Add(entryLongitude);
            stackLayout2.Children.Add(btnGeoCoding);
            stackLayout2.Children.Add(btnReverseGeoCoding);
            stackLayout2.Children.Add(lblLocationInfo);

            stackLayout3.Children.Add(btnGeoLocation);
            stackLayout3.Children.Add(lblGeoLocation);

            
            stackLayout.Children.Add(stackLayout1);
            stackLayout.Children.Add(stackLayout2);
            stackLayout.Children.Add(stackLayout3);
            scrollView.Content = stackLayout;
            this.Content = scrollView;
        }

        private void OnBtnStart_Clicked(object sender, EventArgs e)
        {
            if (Accelerometer.IsMonitoring)
                return;

            Accelerometer.ReadingChanged += OnAccelerometer_ReadingChanged;
            Accelerometer.Start(SensorSpeed.UI);
        }
        

        private void OnBtnStop_Clicked(object sender, EventArgs e)
        {
            if (!Accelerometer.IsMonitoring)
                return;

            Accelerometer.ReadingChanged += OnAccelerometer_ReadingChanged;
            Accelerometer.Stop();
        }

        private void OnAccelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            lblX.Text = e.Reading.Acceleration.X.ToString();
            lblY.Text = e.Reading.Acceleration.Y.ToString();
            lblZ.Text = e.Reading.Acceleration.Z.ToString();
        }

        private async void OnBtnGeoCoding_Clicked(object sender, EventArgs e)
        {
            var result = await Geocoding.GetLocationsAsync(entryLocationName.Text);
            var location = result.FirstOrDefault();

            lblLocationInfo.Text = String.Empty;

            if (location != null)
            {
                lblLocationInfo.Text = $"Latitude : {location.Latitude} \n" +
                                   $"Longitude : {location.Longitude} \n" +
                                   $"Altitude : {location.Altitude} \n";
            }
        }

        private async void OnBtnReverseGeoCoding_Clicked(object sender, EventArgs e)
        {
            var result = await Geocoding.GetPlacemarksAsync(Double.Parse(entryLatitude.Text), Double.Parse(entryLongitude.Text));
            var location = result.FirstOrDefault();

            lblLocationInfo.Text = String.Empty;

            if (location != null)
            {
                lblLocationInfo.Text = $"Latitude : {location.Location.Latitude} \n" +
                                       $"Longitude : {location.Location.Longitude} \n" +
                                       $"Altitude : {location.Location.Altitude} \n" +
                                       $"FeatureName : {location.FeatureName} \n" +
                                       $"CountryCode : {location.CountryCode} \n" +
                                       $"CountryName : {location.CountryName} \n" +
                                       $"PostalCode : {location.PostalCode} \n" +
                                       $"AdminArea : {location.AdminArea} \n" +
                                       $"FeatureName : {location.FeatureName} \n" +
                                       $"SubAdminArea : {location.SubAdminArea} \n" +
                                       $"SubLocality : {location.SubLocality} \n" +
                                       $"SubThoroughfare : {location.SubThoroughfare} \n" +
                                       $"Thoroughfare : {location.Thoroughfare} \n";
            }
        }

        private async void OnBtnGeoLocation_Clicked(object sender, EventArgs e)
        {
            var location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Best));

            if (location != null)
            {
                lblGeoLocation.Text = $"Latitude : {location.Latitude} \n" +
                                      $"Longitude : {location.Longitude} \n" +
                                      $"Altitude : {location.Altitude} \n" +
                                      $"Speed : {location.Speed} \n" +
                                      $"Accuracy : {location.Accuracy} \n" +
                                      $"VerticalAccuracy : {location.VerticalAccuracy} \n" +
                                      $"Course : {location.Course} \n" +
                                      $"Timestamp : {location.Timestamp} \n";
            }

            lblGeoLocation.Text += "\n\n";

            var lastLocation = await Geolocation.GetLastKnownLocationAsync();

            if (lastLocation != null)
            {
                lblGeoLocation.Text += $"Latitude : {lastLocation.Latitude} \n" +
                                      $"Longitude : {lastLocation.Longitude} \n" +
                                      $"Altitude : {lastLocation.Altitude} \n" +
                                      $"Speed : {lastLocation.Speed} \n" +
                                      $"Accuracy : {lastLocation.Accuracy} \n" +
                                      $"VerticalAccuracy : {lastLocation.VerticalAccuracy} \n" +
                                      $"Course : {lastLocation.Course} \n" +
                                      $"Timestamp : {lastLocation.Timestamp} \n";
            }
        }
    }
}