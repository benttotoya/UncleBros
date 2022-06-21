using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UncleBros.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EssentialPage : ContentPage
    {
        public EssentialPage()
        {
            InitializeComponent();

            // DeviceInfo
            var platform = DeviceInfo.Platform.ToString();
            var manufacturer = DeviceInfo.Manufacturer;
            var model = DeviceInfo.Model;
            var devicetype = DeviceInfo.DeviceType.ToString();
            var version = DeviceInfo.Version.ToString();
            var versionstring = DeviceInfo.VersionString;
            var idiom = DeviceInfo.Idiom.ToString();
            var name = DeviceInfo.Name;

            Label lblDeviceInfoTitle = new Label
            {
                Text = "# DeviceInfo",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
            };

            Label lblDeviceInfo = new Label
            {
                Text = $"Platform : {platform} \n" +
                       $"Manufacturer : {manufacturer} \n" +
                       $"Model : {model} \n" +
                       $"DeviceType : {devicetype} \n" +
                       $"Version : {version} \n" +
                       $"VersionString : {versionstring} \n" +
                       $"Idiom : {idiom} \n" +
                       $"Name : {name} \n"
            };

            // DeviceDisplay
            var mainDisplayInfo = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo;
            var orientation = mainDisplayInfo.Orientation;
            var rotation = mainDisplayInfo.Rotation;
            var width = mainDisplayInfo.Width;
            var height = mainDisplayInfo.Height;
            var density = mainDisplayInfo.Density;

            Label lblDeviceDisplayTitle = new Label
            {
                Text = "# DeviceDisplay",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
                Padding = new Thickness(0, 10, 0, 0),
            };

            Label lblDeviceDisplay = new Label
            {
                Text = $"Orientation : {orientation} \n" +
                       $"Rotation : {rotation} \n" +
                       $"Width : {width} \n" +
                       $"Height : {height} \n" +
                       $"Density : {density} \n"
            };

            Xamarin.Essentials.DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;

            // AppInfo
            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var appVersion = AppInfo.Version;
            var build = AppInfo.BuildString;

            Label lblAppInfoTitle = new Label
            {
                Text = "# AppInfo",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
                Padding = new Thickness(0, 10, 0, 0),
            };

            Label lblAppInfo = new Label
            {
                Text = $"AppName : {appName} \n" +
                       $"PackageName : {packageName} \n" +
                       $"AppVersion : {appVersion} \n" +
                       $"Build : {build} \n"
            };

            // Battery
            var batteryLevel = Battery.ChargeLevel.ToString();
            var batteryState = Battery.State;
            string strBatteryState;

            switch (batteryState)
            {
                case BatteryState.Unknown:
                    strBatteryState = "Unknown";
                    break;
                case BatteryState.Charging:
                    strBatteryState = "Charging";
                    break;
                case BatteryState.Discharging:
                    strBatteryState = "Charging";
                    break;
                case BatteryState.Full:
                    strBatteryState = "Full";
                    break;
                case BatteryState.NotCharging:
                    strBatteryState = "NotCharging";
                    break;
                case BatteryState.NotPresent:
                    strBatteryState = "NotPresent";
                    break;
                default:
                    strBatteryState = "Default";
                    break;
            }

            Label lblBatteryTitle = new Label
            {
                Text = "# Battery ",
                FontSize = 12,
                FontAttributes = FontAttributes.Bold,
                Padding = new Thickness(0, 10, 0, 0),
            };

            Label lblBatteryInfo = new Label
            {
                Text = $"BatteryLevel : {batteryLevel} \n" +
                       $"BatteryState : {strBatteryState} \n" +
                       $"AppVersion : {appVersion} \n" +
                       $"Build : {build} \n"
            };

            Battery.EnergySaverStatusChanged += OnBattery_EnergySaverStatusChanged;

            // TTS
            Button btnTTS = new Button
            {
                Text = "TTS Test",
            };

            btnTTS.Clicked += OnbtnTTS_Clicked;


            // 뷰 합체
            StackLayout stackLayout = new StackLayout();

            stackLayout.Children.Add(lblDeviceInfoTitle);
            stackLayout.Children.Add(lblDeviceInfo);

            stackLayout.Children.Add(lblDeviceDisplayTitle);
            stackLayout.Children.Add(lblDeviceDisplay);

            stackLayout.Children.Add(lblAppInfoTitle);
            stackLayout.Children.Add(lblAppInfo);

            stackLayout.Children.Add(lblBatteryTitle);
            stackLayout.Children.Add(lblBatteryInfo);

            stackLayout.Children.Add(btnTTS);

            this.Content = stackLayout;
        }

        private async void OnbtnTTS_Clicked(object sender, EventArgs e)
        {
            string strReadToSpeech = "오하요 고자이마스.";


            CancellationTokenSource cancleTkn = new CancellationTokenSource();
            cancleTkn.Cancel();
            await TextToSpeech.SpeakAsync(strReadToSpeech, cancleTkn.Token);
        }


        private void OnBattery_EnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            
        }
    }
}